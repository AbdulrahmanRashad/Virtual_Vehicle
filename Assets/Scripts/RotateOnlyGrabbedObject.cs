using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnlyGrabbedObject : MonoBehaviour
{
    //[SerializeField] private GameObject grabbedObject;
    //[SerializeField] private Transform grabbedObject;
    private Vector3 initialPosition;

    private void Start()
    {
        // Store the initial position of the grabbed object
        //initialPosition = grabbedObject.transform.position;
    }

    private void Update()
    {
        /*// Check if the user is grabbing the object  (you can replace this with your own logic)
        //if (Input.GetMouseButton(0))
        //{
            // Rotate the grabbed object based on controller input (or any other input method)
            float rotationSpeed = 50f;
            float rotationZ =  rotationSpeed * Time.deltaTime;

            grabbedObject.transform.Rotate(Vector3.forward, rotationZ);

            // Reset the position to the initial position to prevent any position changes
            
        //}*/
       // grabbedObject.transform.position = initialPosition;
    }

    // Call this method when the grab starts
    /*public void StartGrab(GameObject objectToGrab)
    {
        grabbedObject.transform.position = objectToGrab.transform.position;
    }*/
}
