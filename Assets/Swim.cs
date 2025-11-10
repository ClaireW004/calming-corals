using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Swim : MonoBehaviour
{
    public float movementThreshold = 0.01f; 
    public AudioClip movementClip; 
    public bool loopWhileMoving = true;

    private AudioSource audioSource;
    private Vector3 lastPosition;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = movementClip;
        audioSource.loop = loopWhileMoving;
        lastPosition = transform.position;
    }

    void Update()
    {
        float movementSpeed = (transform.position - lastPosition).magnitude / Time.deltaTime;

        if (movementSpeed > movementThreshold)
        {
            if (!audioSource.isPlaying)
                audioSource.Play();
        }
        else
        {
            if (audioSource.isPlaying && !loopWhileMoving)
                audioSource.Stop();
        }

        lastPosition = transform.position;
    }
}
