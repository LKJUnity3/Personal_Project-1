using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JobSelectButton : MonoBehaviour
{
    private string Job;
    [SerializeField] private GameObject Panel;

    public void OnClick()
    {
        Panel.SetActive(true);
    }
    public void OnClickJob()
    {
        Job = GetComponentInChildren<SpriteRenderer>().sprite.name;
        PlayerPrefs.SetString("JobName", Job);
        Panel.SetActive(false);
    }

}
