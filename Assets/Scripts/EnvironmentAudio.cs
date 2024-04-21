using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentAudio : MonoBehaviour
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

            audioSource.PlayOneShot(startEngine);

    }
}
