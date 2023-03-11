using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creature : MonoBehaviour
{
    protected Transform thisTransform;
    private Vector3 startPosition;
    private float verticalVelocity;
    bool myFunctionCalled = false;

    private void Start()
    {
        thisTransform = transform;
        startPosition = thisTransform.position;
    }
    private void Update()
    {
        Move();
        if(myFunctionCalled==false)
        {
            myFunctionCalled = true;
            Talk();
        }
    }
    protected virtual void Move()
    {
        Vector3 pos = startPosition + Vector3.right * Mathf.Sin(Time.time);
        verticalVelocity -= 14*Time.deltaTime;

        if (verticalVelocity < 0) 
         
            verticalVelocity = 0;
            pos.y = verticalVelocity + startPosition.y;
            thisTransform.position = pos;
        
    }

    protected virtual void Talk()
    {
        Debug.Log("Creature Says : Beware");
    }


}
