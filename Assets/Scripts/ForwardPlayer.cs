using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForwardPlayer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position; //+ new Vector3(-0.3f,0.01f,3.2f);
    }
}
