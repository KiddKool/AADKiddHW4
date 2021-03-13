using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float speed = 100.0f;
    private float somevar;
    

    void Update()
    {
        somevar = sliderValue.speedValue;
        transform.Rotate(0f, 0f, speed * somevar * Time.deltaTime);    
    }

    


}
