using UnityEngine;
using TMPro;

public class FishPopupUI : MonoBehaviour
{
    public GameObject popupPanel;
    public TMP_Text fishNameText;
    public TMP_Text fishDescriptionText;

    private void Start()
    {
        popupPanel.SetActive(false);
    }

    public void ShowFishInfo(FishInfo fish)
    {
        fishNameText.text = fish.speciesName;
        fishDescriptionText.text = fish.description;
        popupPanel.SetActive(true);
    }

    public void HideFishInfo()
    {
        popupPanel.SetActive(false);
    }
}
