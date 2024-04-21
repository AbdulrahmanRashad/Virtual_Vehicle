using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MyPlayerManager : MonoBehaviour
{
    [SerializeField] private InputActionReference actionReference;
    [SerializeField] private GameObject MyCar;
    // Start is called before the first frame update
    private void OnEnable()
    {
        actionReference.action.Enable();    
        actionReference.action.performed += TurnCarDirection;
    }


    // Update is called once per frame
    private void OnDisable()
    {
        actionReference.action.performed -= TurnCarDirection;

    }

    private void TurnCarDirection(InputAction.CallbackContext obj)
    {
        float thumbStickValue = actionReference.action.ReadValue<float>();

        MyCar.transform.Rotate(Vector3.up, Time.deltaTime * 25 * thumbStickValue);
        
    }

}
