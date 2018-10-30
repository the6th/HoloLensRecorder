using MessagePack;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class Work02 : MonoBehaviour
{
    [SerializeField]
    GameObject Recorder;
    [SerializeField]
    GameObject Player;
    [SerializeField]
    string filename = "work02.dat";


    List<MyTransform> myTransforms;

    bool isRecording = false;
    bool isPlaying = false;

    float timeFromStart;
    MyTransform startTrans;
    int counter = 0;
    // Use this for initialization
    void Start()
    {
        //初期位置を記録する
        startTrans = new MyTransform();
        startTrans.SetData(Recorder.transform, 0);

        myTransforms = new List<MyTransform>();
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

        if (GUI.Button(new Rect(10, 10, 100, 60), title) && !isPlaying)
        {
            if (isRecording)
                StopRecord();
            else
                StartRecord();

            isRecording = !isRecording;
        }

        title = (!isPlaying ? "再生開始" : "再生中");

        if (GUI.Button(new Rect(10, 100, 100, 60), title) && !isRecording)
        {
            if (isPlaying)
                StopPlay();
            else
                StartPlay();

            isPlaying = !isPlaying;
        }

        GUI.Label(new Rect(20, 160, 100, 20), counter.ToString());


    }
    void StartPlay()
    {
        myTransforms.Clear();
        LoadMessagePack(filename);

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
        SaveMessagePack(filename);
    }

    /// <summary>
    /// シリアライズしてファイルに保存する
    /// </summary>
    /// <param name="_filename"></param>
    void SaveMessagePack(string _filename)
    {
        _filename = Path.Combine(Application.streamingAssetsPath, _filename);

        FileStream fs = new FileStream(_filename, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        BinaryWriter bw = new BinaryWriter(fs);
        var bytes = MessagePackSerializer.Serialize(myTransforms);

        bw.Write(bytes);

        bw.Close();
        fs.Close();
        Debug.Log("save to" + _filename + " length is " + bytes.Length);

    }

    /// <summary>
    /// ファイルから読み込んでデシリアライズする
    /// </summary>
    /// <param name="_filename"></param>
    void LoadMessagePack(string _filename)
    {
        _filename = Path.Combine(Application.streamingAssetsPath, _filename);

        Debug.Log("load from" + _filename);

        //ファイルを開く
        System.IO.FileStream fs = new System.IO.FileStream(_filename, System.IO.FileMode.Open, System.IO.FileAccess.Read);

        //ファイルを読み込むバイト型配列を作成する
        byte[] bs = new byte[fs.Length];
        
        //ファイルの内容をすべて読み込む
        fs.Read(bs, 0, bs.Length);

        //一度Jsonとして取得してみる
        //var loadJson = MessagePackSerializer.ToJson(bs);
        //Debug.Log("loadJson string is " + loadJson);

        myTransforms = MessagePackSerializer.Deserialize<MyTransform[]>(bs).ToList();

        //閉じる
        fs.Close();
    }
}

