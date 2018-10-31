using MessagePack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using MessagePack.Unity;
using MessagePack.Resolvers;


public class Work02 : MonoBehaviour
{
    [SerializeField]
    GameObject Recorder;
    [SerializeField]
    GameObject Player;
    [SerializeField]
    string saveFileName = "work02.dat";


    List<MyTransform> myTransforms;

    bool isRecording = false;
    bool isPlaying = false;

    float timeFromStart;
    MyTransform startTrans;
    int counter = 0;

#if UNITY_WSA
    //UWPではResolverの登録が必要
    void RegistResolver()
    {
        // CompositeResolver is singleton helper for use custom resolver.
        // Ofcourse you can also make custom resolver.
        MessagePack.Resolvers.CompositeResolver.RegisterAndSetAsDefault(
            // use generated resolver first, and combine many other generated/custom resolvers
            MessagePack.Resolvers.GeneratedResolver.Instance,
            // finally, use builtin/primitive resolver(don't use StandardResolver, it includes dynamic generation)
            MessagePack.Resolvers.BuiltinResolver.Instance,
            //Vector3を取り扱うには、UnityResolverも登録しないといけない
            MessagePack.Unity.UnityResolver.Instance,
            AttributeFormatterResolver.Instance,
            MessagePack.Resolvers.PrimitiveObjectResolver.Instance
        );
    }
#endif

    // Use this for initialization
    void Start()
    {

#if UNITY_WSA
        RegistResolver();
#endif
        //初期位置を記録する
        startTrans = new MyTransform();
        startTrans.SetData(Recorder.transform, 0);

        myTransforms = new List<MyTransform>();


#if ENABLE_DOTNET
        Debug.Log(".net");
#endif

#if ENABLE_IL2CPP
        Debug.Log("IL2CPP");
#endif

#if WINDOWS_UWP
        // UWP上での動作の場合、LocalAppData/AppName/LocalStateフォルダを参照する
        saveFileName = System.IO.Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, saveFileName);
#else
        // Unity上での動作の場合、Assets/StreamingAssetsフォルダを参照する
        saveFileName = System.IO.Path.Combine(UnityEngine.Application.streamingAssetsPath, saveFileName);

#endif

        //   TestObjList();
    }



    // Update is called once per frame
    void Update()
    {
        float time = Time.realtimeSinceStartup - timeFromStart;

        if (isRecording)
        {
            MyTransform t = new MyTransform();
            t.SetData(Recorder.transform, time);
            myTransforms.Add(t);
            counter++;

        }
        else if (isPlaying)
        {
            //最後まで再生したらループする
            if (counter >= myTransforms.Count)
            {
                StartPlay();
            }
            else
            {
                var playTransform = myTransforms[counter];

                if (time > playTransform.Time)
                {
                    Player.transform.position = playTransform.Pos;
                    Player.transform.rotation = playTransform.Rot;
                    Player.transform.localScale = playTransform.Scale;
                    counter++;
                }
            }
        }
    }


    private void OnGUI()
    {
        string title;
        title = (!isRecording ? "録画開始" : "録画中");

        if (GUI.Button(new Rect(10, 10, 300, 200), title) && !isPlaying)
        {
            if (isRecording)
                StopRecord();
            else
                StartRecord();

            isRecording = !isRecording;
        }

        title = (!isPlaying ? "再生開始" : "再生中");

        if (GUI.Button(new Rect(10, 260, 300, 200), title) && !isRecording)
        {
            if (isPlaying)
                StopPlay();
            else
                StartPlay();

            isPlaying = !isPlaying;
        }

        GUI.Label(new Rect(20, 400, 100, 20), counter.ToString());


    }




    void StartPlay()
    {
        myTransforms.Clear();
        LoadMessagePack(saveFileName);

        //再生開始
        counter = 0;
        timeFromStart = Time.realtimeSinceStartup;
        Player.SetActive(true);
    }

    void StopPlay()
    {
        //再生停止
        Player.SetActive(false);
    }

    void StartRecord()
    {
        //録画開始
        myTransforms.Clear();
        Recorder.transform.position = startTrans.Pos;
        Recorder.transform.rotation = startTrans.Rot;
        Recorder.transform.localScale = startTrans.Scale;
        var rigdbody = Recorder.GetComponent<Rigidbody>();
        rigdbody.velocity = Vector3.zero;
        //     rigdbody.angularVelocity = Vector3.zero;
        rigdbody.ResetInertiaTensor();

        Recorder.SetActive(true);

        timeFromStart = Time.realtimeSinceStartup;
    }

    void StopRecord()
    {
        Recorder.SetActive(false);
        SaveMessagePack(saveFileName);
    }

    /// <summary>
    /// シリアライズしてファイルに保存する
    /// </summary>
    /// <param name="_filename"></param>
    void SaveMessagePack(string _filename)
    {
        //シリアライズデータを作成
        var send = new MsgPackSend();
        send.array = myTransforms.ToArray();
        var bytes = MessagePackSerializer.Serialize(send);

        //ファイルオープン
#if !UNITY_EDITOR && UNITY_WSA
        BinaryWriter bw = new BinaryWriter(File.Open(_filename, FileMode.OpenOrCreate));
#else
        FileStream fs = new FileStream(_filename, FileMode.Create, FileAccess.ReadWrite);
        BinaryWriter bw = new BinaryWriter(fs);
#endif

        //書き込み処理
        bw.Write(bytes);


        //ファイルクローズ
#if !UNITY_EDITOR && UNITY_WSA
        bw.Flush();
        bw.Dispose();
#else
        bw.Close();
        fs.Close();
#endif
        Debug.Log("save to" + _filename + " length is " + bytes.Length);

    }

    /// <summary>
    /// ファイルから読み込んでデシリアライズする
    /// </summary>
    /// <param name="_filename"></param>
    void LoadMessagePack(string _filename)
    {

        Debug.Log("load from" + _filename);

        //ファイルを開く
        System.IO.FileStream fs = new System.IO.FileStream(_filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);

        //ファイルを読み込むバイト型配列を作成する
        byte[] bs = new byte[fs.Length];

        //ファイルの内容をすべて読み込む
        fs.Read(bs, 0, bs.Length);

        //一度Jsonとして取得してみる
        var loadJson = MessagePackSerializer.ToJson(bs);
        Debug.Log("loadJson string is " + loadJson);

        myTransforms = MessagePackSerializer.Deserialize<MsgPackSend>(bs).array.ToList();

        //ファイルクローズ
#if !UNITY_EDITOR && UNITY_WSA
        fs.Dispose();
#else
        fs.Close();
#endif
    }
}

