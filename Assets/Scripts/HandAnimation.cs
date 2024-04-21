using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class HandAnimation : MonoBehaviour
{
    public InputActionProperty triggerButton;
    public InputActionProperty gripButton;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float triggerButtonValue = triggerButton.action.ReadValue<float>();
        float gripButtonValue = triggerButton.action.ReadValue<float>();
        animator.SetFloat("Trigger", triggerButtonValue);
        animator.SetFloat("Grip", gripButtonValue);

    }
}
