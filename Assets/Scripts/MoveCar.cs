using System.Collections;
using System.Collections.Generic;
using Unity.XR.OpenVR;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;


public class MoveCar : MonoBehaviour
{
    //Start is called before the first frame update
    private float speed = 5.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    public void RunCar()
    {
        
        while(speed < 40)
        {
            speed++;
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

         transform.Translate(Vector3.forward*Time.deltaTime * speed );
       // transform.Rotate(Vector3.up, Time.deltaTime * turnspeed * left_button_value);
    }
}
