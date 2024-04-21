using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarStop : MonoBehaviour
{
    [SerializeField] GameObject car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void StopCar()
    {
        car.GetComponent<Rigidbody>().AddForce(transform.forward, 0);
    }
}
