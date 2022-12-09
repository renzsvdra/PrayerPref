using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadData : MonoBehaviour
{
    public Text UnameBox;
    void Start()
    {
        UnameBox.text=PlayerPrefs.GetString("username");
    }

    public void clickReset()
    {
        PlayerPrefs.DeleteKey("username");
        SceneManager.LoadScene("FirstScene");

    }
}
