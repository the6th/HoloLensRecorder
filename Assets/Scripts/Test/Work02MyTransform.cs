﻿using MessagePack;
using UnityEngine;


[MessagePackObject]
public class MsgPackSend
{
    [Key(4)]
    public MyTransform[] array { get; set; }

}
[MessagePackObject]
public class MyTransform
{
    [Key(0)]
    public Vector3 Pos { get; set; }

    [Key(1)]
    public Quaternion Rot { get; set; }

    [Key(2)]
    public Vector3 Scale { get; set; }

    [Key(3)]
    public float Time { get; set; }

    public void SetData(Transform t,float time)
    {
        Time = time;
        Pos = t.position;
        Rot = t.rotation;
        Scale = t.localScale;
    }
}
