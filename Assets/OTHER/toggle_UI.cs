using UnityEngine;

public class ToggleUIWithZ : MonoBehaviour
{
    public CanvasGroup uiGroup;
    private bool isVisible = true;

    void Start()
    {
        if (uiGroup == null)
            Debug.LogWarning("ToggleUIWithZ: uiGroup is not assigned!");
        else
            SetVisible(isVisible);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (uiGroup == null) return;
            isVisible = !isVisible;
            SetVisible(isVisible);
        }
    }

    void SetVisible(bool visible)
    {
        uiGroup.alpha = visible ? 1f : 0f;          // show / hide
        uiGroup.interactable = visible;            // can click when visible
        uiGroup.blocksRaycasts = visible;          // blocks XR/ mouse rays when visible
    }
}
