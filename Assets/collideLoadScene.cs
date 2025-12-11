using UnityEngine;
using UnityEngine.SceneManagement; // Required for SceneManager

public class SceneLoader : MonoBehaviour
{
    public int sceneToLoad; // Assign the name of the scene to load in the Inspector

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger is the VR player
        // You might want to use a specific tag like "Player" for better filtering
        if (other.CompareTag("MainCamera")) 
        {
            Debug.Log("TRIGGERED");
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}
