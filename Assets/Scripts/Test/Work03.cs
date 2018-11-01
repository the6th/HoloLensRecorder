using MessagePack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using MessagePack.Unity;
using MessagePack.Resolvers;
using System.Collections;

public class Work03 : MonoBehaviour
{
    [SerializeField]
    GameObject[] Recorders;
    [SerializeField]
    GameObject[] Players;
    [SerializeField]
    string saveFileName = "work03.dat";


    List<MultiTransform> myTransforms;

    bool isRecording = false;
    bool isPlaying = false;

    float timeFromStart;
    MultiTransform[] startTrans;
    int counter = 0;

    Color orginColor;

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


    private void Awake()
    {
        //Display.displays[0].Activate();
        //Display.displays[1].Activate();
    }
    // Use this for initialization
    void Start()
    {

#if UNITY_WSA
        RegistResolver();
#endif
        //初期位置を記録する

        startTrans = new MultiTransform[Recorders.Length];

        for (int i = 0; i < Recorders.Length; i++)
        {
            int id = i;
            Recorders[i].GetComponent<Work03Cube>().OnCubeHit.AddListener(() => HitCube(id));
            startTrans[i] = new MultiTransform();
            startTrans[i].SetData(i, Recorders[i].transform, 0);
        }

        orginColor = Recorders[0].GetComponent<Renderer>().material.color;
        myTransforms = new List<MultiTransform>();


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

    private void OnDestroy()
    {
        for (int i = 0; i < Recorders.Length; i++)
        {
            int id = i;
            Recorders[i].GetComponent<Work03Cube>().OnCubeHit.RemoveAllListeners();
        }
    }

    void HitCube(int id)
    {

        if (isPlaying)
        {
            Players[id].GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            float time = Time.realtimeSinceStartup - timeFromStart;
            Recorders[id].GetComponent<Renderer>().material.color = Color.green;
            var t = new MultiTransform();
            t.ID = id;
            t.Type = EVENT_TYPE.EVENT_1;
            t.Time = time;
            t.EventString = "hit[" + id +"]" + time;
            myTransforms.Add(t);

        }
        StartCoroutine(ColorDefault(id));
    }



    IEnumerator ColorDefault(int id)
    {
        yield return new WaitForSeconds(0.05f);
        if (isPlaying)
        {
            Players[id].GetComponent<Renderer>().material.color = orginColor;
        }
        else
        {
            Recorders[id].GetComponent<Renderer>().material.color = orginColor;
        }

    }

    // Update is called once per frame
    void Update()
    {
        float time = Time.realtimeSinceStartup - timeFromStart;

        if (isRecording)
        {
            for (int i = 0; i < Recorders.Length; i++)
            {
                MultiTransform t = new MultiTransform();
                t.SetData(i, Recorders[i].transform, time);
                myTransforms.Add(t);
                counter++;
            }
        }
        else if (isPlaying)
        {

            //最後まで再生したらループする
            if (counter < myTransforms.Count)
            {
                LoopPlay();
            }
            else
            {
                StartPlay();
            }
        }
    }

    private void LoopPlay()
    {
        float time = Time.realtimeSinceStartup - timeFromStart;

        while (true)
        {
            if (myTransforms[counter] == null)
            {
                counter++;

                break;
            }

            var playTransform = myTransforms[counter];

            if (time > playTransform.Time)
            {
                switch (playTransform.Type)
                {
                    case EVENT_TYPE.TRANSFORM:
                        Players[playTransform.ID].transform.position = playTransform.Pos;
                        Players[playTransform.ID].transform.rotation = playTransform.Rot;
                        Players[playTransform.ID].transform.localScale = playTransform.Scale;
                        break;

                    default:
                        HitCube(playTransform.ID);
                        break;
                }
                counter++;
            }
            else
            {

                break;
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
        Debug.Log("StartPlay");

        myTransforms.Clear();
        orginColor = Recorders[0].GetComponent<Renderer>().material.color;

        LoadMessagePack(saveFileName);

        //再生開始
        counter = 0;
        timeFromStart = Time.realtimeSinceStartup;

        for (int i = 0; i < Players.Length; i++)
        {
            Players[i].SetActive(true);
        }
    }

    void StopPlay()
    {
        Debug.Log("StopPlay");

        //再生停止
        for (int i = 0; i < Players.Length; i++)
        {
            Players[i].SetActive(false);
        }
    }

    void StartRecord()
    {
        orginColor = Recorders[0].GetComponent<Renderer>().material.color;

        //録画開始
        myTransforms.Clear();

        for (int i = 0; i < Recorders.Length; i++)
        {
            var r = Recorders[i];
            r.transform.position = startTrans[i].Pos;
            r.transform.rotation = startTrans[i].Rot;
            r.transform.localScale = startTrans[i].Scale;
            var rigdbody = r.GetComponent<Rigidbody>();
            rigdbody.velocity = Vector3.zero;
            //     rigdbody.angularVelocity = Vector3.zero;
            rigdbody.ResetInertiaTensor();

            r.SetActive(true);
        }



        timeFromStart = Time.realtimeSinceStartup;
    }

    void StopRecord()
    {
        for (int i = 0; i < Recorders.Length; i++)
        {
            var r = Recorders[i];
            r.SetActive(false);
        }

        SaveMessagePack(saveFileName);
    }

    /// <summary>
    /// シリアライズしてファイルに保存する
    /// </summary>
    /// <param name="_filename"></param>
    void SaveMessagePack(string _filename)
    {
        //シリアライズデータを作成
        var send = new MsgPackMultiTransformSend();
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

        myTransforms = MessagePackSerializer.Deserialize<MsgPackMultiTransformSend>(bs).array.ToList();

        //ファイルクローズ
#if !UNITY_EDITOR && UNITY_WSA
        fs.Dispose();
#else
        fs.Close();
#endif
    }
}

