using UnityEngine;
using MessagePack;

public class Work01 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        session01();
    }

    void session01()
    {
        var mc = new MyClass
        {
            Age = 99,
            FirstName = "hoge",
            LastName = "huga",
        };

        // call Serialize/Deserialize, that's all.
        var bytes = MessagePackSerializer.Serialize(mc);
        var mc2 = MessagePackSerializer.Deserialize<MyClass>(bytes);

        // you can dump msgpack binary to human readable json.
        // In default, MeesagePack for C# reduce property name information.
        // [99,"hoge","huga"]
        var json = MessagePackSerializer.ToJson(bytes);
        Debug.Log(json);
    }
}
