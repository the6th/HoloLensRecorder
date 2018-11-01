using MessagePack;
using UnityEngine;


public enum EVENT_TYPE
{
    TRANSFORM,
    EVENT_1,
    EVENT_2
}

[MessagePackObject]
public class MsgPackMultiTransformSend
{
    [Key(7)]
    public MultiTransform[] array { get; set; }

}

[MessagePackObject]
public class MultiTransform
{
    [Key(0)]
    public int ID { get; set; }

    [Key(5)]
    public EVENT_TYPE Type { get; set; }

    [Key(6)]
    public string EventString { get; set; }

    [Key(1)]
    public Vector3 Pos { get; set; }

    [Key(2)]
    public Quaternion Rot { get; set; }

    [Key(3)]
    public Vector3 Scale { get; set; }

    [Key(4)]
    public float Time { get; set; }

    public void SetData(int id, Transform t, float time, EVENT_TYPE type = EVENT_TYPE.TRANSFORM,string event_string = "")
    {
        ID = id;
        Type = type;
        Time = time;
        Pos = t.position;
        Rot = t.rotation;
        Scale = t.localScale;
        EventString = event_string;
    }
}
