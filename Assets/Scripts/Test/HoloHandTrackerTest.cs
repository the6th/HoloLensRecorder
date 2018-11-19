using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input;



public class HoloHandTrackerTest : MonoBehaviour
{

    public GameObject Head;
    public GameObject rightHand;
    public GameObject leftHand;
    Transform CamTrans;
    void Start()
    {
        CamTrans = Camera.main.transform;
        rightHand.transform.localScale = leftHand.transform.localScale = Vector3.zero;

        InteractionManager.InteractionSourceUpdated += InteractionSourceUpdated;
        InteractionManager.InteractionSourcePressed += InteractionSourcePressed;
        InteractionManager.InteractionSourceReleased += InteractionSourceReleased;
        InteractionManager.InteractionSourceLost += InteractionSourceLost;
    }

    private void OnDestroy()
    {
        InteractionManager.InteractionSourceUpdated -= InteractionSourceUpdated;
        InteractionManager.InteractionSourcePressed -= InteractionSourcePressed;
        InteractionManager.InteractionSourceReleased -= InteractionSourceReleased;
        InteractionManager.InteractionSourceLost -= InteractionSourceLost;
    }

    private void Update()
    {
        Head.transform.SetPositionAndRotation(CamTrans.position, CamTrans.rotation);
    }

    void UpdateCube(uint id, Vector3 pos, bool active = true)
    {
        GameObject target;
        if (id % 2 == 0)
            target = rightHand;
        else
            target = leftHand;
        target.transform.position = pos;
        if (active == true)
            target.transform.localScale = Vector3.one * 0.01f;
        else
            target.transform.localScale = Vector3.zero;

    }

    private void InteractionSourceLost(InteractionSourceLostEventArgs obj)
    {
        Debug.Log("InteractionSourceLost ID" + obj.state.source.id);
        UpdateCube(obj.state.source.id, Vector3.zero, false);

        //throw new NotImplementedException();
    }

    private void InteractionSourceReleased(InteractionSourceReleasedEventArgs obj)
    {
        //Debug.Log("InteractionSourceReleased ID" + obj.state.source.id);

        //throw new NotImplementedException();
    }

    private void InteractionSourcePressed(InteractionSourcePressedEventArgs obj)
    {
        //Debug.Log("InteractionSourcePressed ID" + obj.state.source.id);
        //throw new NotImplementedException();
    }

    private void InteractionSourceUpdated(InteractionSourceUpdatedEventArgs obj)
    {

        Vector3 pos;
        if (obj.state.sourcePose.TryGetPosition(out pos))
        {
            if (pos != Vector3.zero)
            {
                //Debug.Log("InteractionSourceUpdated ID" + obj.state.source.id + " pos " + pos);
                // オブジェクトの位置を手の位置に更新
                UpdateCube(obj.state.source.id, pos, true);
            }
        }


    }
}
