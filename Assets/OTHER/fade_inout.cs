using UnityEngine;

[RequireComponent(typeof(CanvasGroup))]
public class fade_inout : MonoBehaviour
{
    public Transform viewer;
    public Transform target;
    public float fadeInDistance = 2f;
    public float fadeOutDistance = 6f;

    CanvasGroup canvasGroup;

    void Awake()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        if (target == null) target = transform;
    }

    void Update()
    {
        if (viewer == null) return;

        float dist = Vector3.Distance(viewer.position, target.position);
        float alpha = Mathf.InverseLerp(fadeOutDistance, fadeInDistance, dist);

        canvasGroup.alpha = alpha;

        bool visible = alpha > 0.05f;
        canvasGroup.interactable = visible;
        canvasGroup.blocksRaycasts = visible;
    }
}
