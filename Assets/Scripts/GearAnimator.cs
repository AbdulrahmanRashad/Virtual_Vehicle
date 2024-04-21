using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearAnimator : MonoBehaviour
{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ForwardActive()
    {
        animator.SetBool("IsForward", true);
        Debug.Log("Forward");
       // animator.SetBool("IsReverse", false);
    }
    public void ReverseActive()
    {
        animator.SetBool("IsForward", false);
        Debug.Log("Reverse");
        //animator.SetBool("IsReverse", true);
    }
}
