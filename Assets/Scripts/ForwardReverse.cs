using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ForwardReverse : MonoBehaviour
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

        MyCar.transform.Translate(Vector3.forward * Time.deltaTime * 20 * thumbStickValue);

    }
}
