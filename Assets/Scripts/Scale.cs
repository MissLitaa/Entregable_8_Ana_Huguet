using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour

{
    private Vector3 ResetValue;

    private void Start()
    {
        ResetValue = Vector3.one;
    }
    
    public void ScaleBlock(float value)
    {
            transform.localScale = value * Vector3.one ;
    }

    public void Reset()
    {
        transform.localScale = ResetValue; 
    }

    public void Visibility(float value)
    {

        gameObject.SetActive(value >= 0.5f ? true : false); 
        
    }
}
