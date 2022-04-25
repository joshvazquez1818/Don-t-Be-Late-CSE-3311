using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LoadManager : MonoBehaviour
{
    private int savedLevel;
    private string buttonName;
    private int buttonInt;
    public GameObject[] buttons;
    public void LoadLevel()
    {
        buttonName = EventSystem.current.currentSelectedGameObject.name;
        buttonInt = Convert.ToInt32(buttonName);
        SceneManager.LoadScene(buttonInt);
    }
    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }
    // Start is called before the first frame update
    void Start()
    {
        
        foreach (GameObject button in buttons)
        {
            button.SetActive(false);
        }
        if (PlayerPrefs.HasKey("level"))
        {
            Debug.Log(PlayerPrefs.GetInt("level").ToString());
            savedLevel = PlayerPrefs.GetInt("level");
            for (int i = 0; i <= savedLevel; i++)
            {
                buttons[i].SetActive(true);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}