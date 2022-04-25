using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float currentTime;
    public int startMinutes;
    public Text currentTimeText;
    bool timerActive = true;
    // Start is called before the first frame update
    void Start()
    {
        // Convert starting time to seconds
        currentTime = startMinutes * 60;
    }

    // Update is called once per frame
    void Update()
    {
        // If timer hasnt reached 0
        if (timerActive == true)
        {
            // Count down timer
            currentTime = currentTime - Time.deltaTime;
            // Restart level when timer reaches 0
            if(currentTime <= 0) 
            {
                timerActive = false;
                ChangeScene();
            }
        }
        // Display timer
        TimeSpan time = TimeSpan.FromSeconds(currentTime);
        currentTimeText.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public float returnTime()
    {
        return currentTime;
    }
}
