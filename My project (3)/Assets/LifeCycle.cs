using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    private void Update()
    {
        if(Input.anyKeyDown)
            Debug.Log("Pressed any key");
        
        if(Input.GetKeyDown(KeyCode.Return))
            Debug.Log("Item Purchased");
        
        if(Input.GetKey(KeyCode.LeftArrow))
            Debug.Log("Going Left");
        
        if(Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("Stopped moving right");
    }
}
