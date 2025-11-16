using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public Transform centerPoint;

    public float orbitSpeed = 20f;
    public float speedVariance = 5f;

    public float radiusX = 6f;
    public float radiusZ = 3f;

    private float angle = 0f;

    void Start()
    {
        // Randomize orbitSpeed slightly for each fish
        orbitSpeed += Random.Range(-speedVariance, speedVariance);
    }

    void Update()
    {
        if (centerPoint == null) return;

        angle += orbitSpeed * Time.deltaTime;

        float x = Mathf.Cos(angle) * radiusX;
        float z = Mathf.Sin(angle) * radiusZ;

        Vector3 newPos = centerPoint.position + new Vector3(x, 0, z);
        transform.position = newPos;

        // Make the fish face the direction of travel
        transform.rotation = Quaternion.LookRotation(newPos - transform.position);
    }
}
