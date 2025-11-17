using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TrashItem : MonoBehaviour
{
    private TrashCollectionManager manager;

    void Start()
    {
        manager = FindObjectOfType<TrashCollectionManager>();
        GetComponent<XRGrabInteractable>().selectEntered.AddListener(OnGrab);
    }

    private void OnGrab(SelectEnterEventArgs args)
    {
        gameObject.SetActive(false);

        manager.OnTrashCollected();
    }
}
