using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGate : MonoBehaviour
{
    [SerializeField]private Animator animator;
    // Start is called before the first frame update
    void Awake()
    {
        animator.GetComponent<Animator>();
        
    }
    void Start()
    {
        animator.SetBool("Open", true);
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        // transform.Rotate(Vector3.up * Time.deltaTime * speed);
    }
}
