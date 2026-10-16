using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(new Vector3(Time.deltaTime*5*-1,0,0));
    }
}
