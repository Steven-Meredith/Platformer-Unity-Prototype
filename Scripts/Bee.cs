using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bee : MonoBehaviour
    
{
    [SerializeField]
    private Vector3 sP;
    private float vV;
    protected Transform tT;
    
    // Start is called before the first frame update
    void Start()
    {

        transform.position += new Vector3(0, 3, 0);   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    
}
