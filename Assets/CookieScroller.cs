using UnityEngine;

public class CookieAnimator : MonoBehaviour
{
    public Light dirLight;      // Your directional light
    public Texture[] cookies;   // Assign your 32 caustic textures in the Inspector
    public float framesPerSecond = 10f;

    private int currentFrame = 0;
    private float timer = 0f;

    void Update()
    {
        if (cookies.Length == 0 || dirLight == null) return;

        timer += Time.deltaTime;

        if (timer >= 1f / framesPerSecond)
        {
            currentFrame = (currentFrame + 1) % cookies.Length;
            dirLight.cookie = cookies[currentFrame];
            timer -= 1f / framesPerSecond;
        }
    }
}
