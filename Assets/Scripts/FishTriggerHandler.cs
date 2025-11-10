using UnityEngine;

public class FishTriggerHandler : MonoBehaviour
{
    public FishPopupUI popupUI;

    private void OnTriggerEnter(Collider other)
    {
        FishInfo fish = other.GetComponent<FishInfo>();
        if (fish != null)
        {
            popupUI.ShowFishInfo(fish);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FishInfo fish = other.GetComponent<FishInfo>();
        if (fish != null)
        {
            popupUI.HideFishInfo();
        }
    }
}
