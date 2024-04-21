using System.Collections;
using System.Collections.Generic;
using Unity.XR.OpenVR;
using UnityEngine;
using UnityEngine.InputSystem;

public class StartEngine : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip startEngine;
    public AudioSource audioSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ( Input.GetButton("Oculus_A_Button"))
        {
            audioSource.PlayOneShot(startEngine);
        }
        
    }
}
