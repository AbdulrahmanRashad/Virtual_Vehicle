using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomGrabLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool isGrabbed = false;

    // Called when the object is grabbed
    public void OnGrab()
    {
        isGrabbed = true;
        // Add any other logic you need when the object is grabbed
    }

    // Called when the object is released
    public void OnRelease()
    {
        isGrabbed = false;
        // Add any other logic you need when the object is released
    }
}
