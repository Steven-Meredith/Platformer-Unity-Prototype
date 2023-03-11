using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogre : Creature
{
    protected override void Talk()
    {
        
        Debug.Log("Ogre says Grrrrr");
    }

    protected override void Move()
    {
        base.Move();
        thisTransform.position += Vector3.up * Mathf.Sin(Time.time);
    }
}
