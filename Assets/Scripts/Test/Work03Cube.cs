using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Work03Cube : MonoBehaviour {

    public UnityEvent OnCubeHit;

    void Start()
    {
        if (OnCubeHit == null)
            OnCubeHit = new UnityEvent();
    }

    void OnCollisionEnter()
    {

        //イベントを発火する
        if (OnCubeHit != null)
            OnCubeHit.Invoke();
    }
}
