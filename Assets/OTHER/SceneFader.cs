using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneFader : MonoBehaviour
{
    public static SceneFader Instance;

    [Header("Fade Image (full-screen black UI Image)")]
    public Image fadeImage;
    public float fadeDuration = 1f;

    [Header("Audio Fade")]
    public bool fadeAudio = true;
    public float minVolume = 0f;
    private float originalVolume = 1f;

    private bool isTransitioning = false;

    private void Awake()
    {
        // Singleton pattern
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

        originalVolume = AudioListener.volume;

        // Make sure we start fully transparent
        if (fadeImage != null)
        {
            Color c = fadeImage.color;
            c.a = 0f;
            fadeImage.color = c;
        }
    }

    public void FadeToScene(string sceneName)
    {
        if (!isTransitioning)
        {
            StartCoroutine(FadeOutIn(sceneName));
        }
    }

    private IEnumerator FadeOutIn(string sceneName)
    {
        if (fadeImage == null)
        {
            // Failsafe: if no image assigned, just load scene
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
            yield break;
        }

        isTransitioning = true;

        Color c = fadeImage.color;
        float t = 0f;

        // ---------- Fade OUT (0 -> 1 alpha) ----------
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            float p = Mathf.Clamp01(t / fadeDuration);

            c.a = p;
            fadeImage.color = c;

            if (fadeAudio)
                AudioListener.volume = Mathf.Lerp(originalVolume, minVolume, p);

            yield return null;
        }

        // Force final state
        c.a = 1f;
        fadeImage.color = c;
        if (fadeAudio) AudioListener.volume = minVolume;

        // ---------- Load scene ----------
        yield return SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Single);

        // ---------- Fade IN (1 -> 0 alpha) ----------
        t = 0f;
        while (t < fadeDuration)
        {
            t += Time.deltaTime;
            float p = Mathf.Clamp01(t / fadeDuration);

            c.a = 1f - p;
            fadeImage.color = c;

            if (fadeAudio)
                AudioListener.volume = Mathf.Lerp(minVolume, originalVolume, p);

            yield return null;
        }

        // Final state: fully clear, volume restored
        c.a = 0f;
        fadeImage.color = c;
        if (fadeAudio) AudioListener.volume = originalVolume;

        isTransitioning = false;
    }
}
