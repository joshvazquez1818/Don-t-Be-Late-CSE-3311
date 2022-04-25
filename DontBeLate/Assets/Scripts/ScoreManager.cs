using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text displayLevel;
    public Text displayTime;
    private int savedLevel;
    private float savedTime;
    public void BackButton()
    {
        SceneManager.LoadScene(0);
    }
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("level"))
        {
            savedLevel = PlayerPrefs.GetInt("level");
            for(int i = 1; i <= savedLevel; i++)
            {
                savedTime = PlayerPrefs.GetFloat("time" + i);
                TimeSpan time = TimeSpan.FromSeconds(savedTime);
                displayLevel.text += i.ToString() + "\n";
                displayTime.text += time.Minutes.ToString() + ":" + time.Seconds.ToString() + "\n";
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
