using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private Text PlayerName;
    private string Job;
    private void Awake()
    {
        Job = PlayerPrefs.GetString("JobName");
        Debug.Log(Job);
        PlayerName.text = PlayerPrefs.GetString("CurrentPlayerName");
        Player.GetComponentInChildren<SpriteRenderer>().sprite = Resources.Load<Sprite>(Job);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
