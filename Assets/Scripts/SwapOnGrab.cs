using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SwapOnGrab : MonoBehaviour
{
    public GameObject Fish;    // Assign in Inspector
    private XRGrabInteractable grabInteractable;

    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.selectEntered.AddListener(OnGrab);
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        // Hide / deactivate A
        gameObject.SetActive(false);

        // Show / activate B
        if (Fish != null)
            Fish.SetActive(true);
    }
}
