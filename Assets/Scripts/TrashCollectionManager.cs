using UnityEngine;

public class TrashCollectionManager : MonoBehaviour
{
    public GameObject[] animals; 
    private int revealIndex = 0;

    private void Start()
    {
        foreach (var a in animals)
            a.SetActive(false);
    }

    public void OnTrashCollected()
    {
        if (revealIndex < animals.Length)
        {
            animals[revealIndex].SetActive(true);
            revealIndex++;
        }
    }
}
