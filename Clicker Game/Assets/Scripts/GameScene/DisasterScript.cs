using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisasterScript : MonoBehaviour
{
    public GameObject statusBox;
    public float ResourceCheck;
    public int genChance;
    public bool disasterActive = false;
    public int ResourceLoss;

    void Update()
    {
        ResourceCheck = GlobalResources.ResourceCount / 10; //wartośc 10 podczas testów, domyślnie zmienić na 100
        if (disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }
    }

    IEnumerator StartDisaster()
    {
        disasterActive = true;
        genChance = Random.Range(1, 20); //Generowanie prawdopodobieństwa, 20 podczas testów domyślnie zmienić na 200
        if (ResourceCheck >= genChance)
        {
            ResourceLoss = Mathf.RoundToInt(GlobalResources.ResourceCount * 0.25f);
            statusBox.GetComponent<Text>().text = "You lost " + ResourceLoss + " resources in a warehouse fire";
            GlobalResources.ResourceCount -= ResourceLoss;
            yield return new WaitForSeconds(3);
            statusBox.GetComponent<Animation>().Play("StatusAnim");
            yield return new WaitForSeconds(1);
            statusBox.SetActive(false);
            statusBox.SetActive(true);
        }
        yield return new WaitForSeconds(10);
        disasterActive = false;
    }
}
