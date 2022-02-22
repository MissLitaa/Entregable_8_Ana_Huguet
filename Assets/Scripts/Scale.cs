using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour

{
    //Valor de reset del cubo. En Start lo establecemos.
    private Vector3 ResetValue;

    private void Start()
    {
        ResetValue = Vector3.one;
    }

    //Transformar la escala +1 en todos los ejes.
    public void ScaleBlock(float value)
    {
            transform.localScale = value * Vector3.one ;
    }

    public void Reset()
    {
        transform.localScale = ResetValue; 
    }

    //Visibilidad controlada por el valor de Scrollbar.
    public void Visibility(float value)
    {

        gameObject.SetActive(value >= 0.5f ? true : false); 
        
    }
}
