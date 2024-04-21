using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with any other object
        if (collision.gameObject.tag == "Obstacle") // Change "Obstacle" to the tag of your obstacle objects
        {
            // Restart the game by reloading the scene
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
