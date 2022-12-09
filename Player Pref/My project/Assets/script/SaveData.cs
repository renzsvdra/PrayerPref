using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SaveData : MonoBehaviour
{
    public InputField textBox;

    public void clickSave()
    {
        PlayerPrefs.SetString("username", textBox.text);
        Debug.Log(PlayerPrefs.GetString("username"));
        SceneManager.LoadScene("SecondScene");
    }
}
