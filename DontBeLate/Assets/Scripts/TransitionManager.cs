using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class TransitionManager : MonoBehaviour
{
    private int lastLevel;
    public void ToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void NextLevel()
    {
        lastLevel += 1;
        SceneManager.LoadScene(lastLevel);
    }
    // Start is called before the first frame update
    void Start()
    {
        lastLevel = PlayerPrefs.GetInt("lastCompleted", 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
