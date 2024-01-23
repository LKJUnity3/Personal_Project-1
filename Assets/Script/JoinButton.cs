using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JoinButton : MonoBehaviour
{
    [SerializeField] private InputField PlayerNameInput;
    private string PlayerName;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Onclick()
    {
        PlayerName = PlayerNameInput.GetComponent<InputField>().text;
        if (PlayerName.Length >= 2 && PlayerName.Length <= 10)
        {
            InputName();
        }
        else
        {
            Debug.Log("else");
        }
    }

    public void InputName()
    {
        PlayerName = PlayerNameInput.text;
        PlayerPrefs.SetString("CurrentPlayerName", PlayerName);
        SceneManager.LoadScene("MainScene");
    }
    // Update is called once per frame
}
