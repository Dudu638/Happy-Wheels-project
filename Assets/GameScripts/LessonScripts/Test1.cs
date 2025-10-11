using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test1 : MonoBehaviour
{
    public Action onPressed;



    private void OnEnable()
    {
        Debug.Log("OnEnable");
        onPressed += Test;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onPressed?.Invoke();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            onPressed += Test;
        }
        if (!Input.GetKeyDown(KeyCode.S))
        {
            onPressed -= Test;
        }
    }
    private void Test() => Debug.Log("Test");
}
