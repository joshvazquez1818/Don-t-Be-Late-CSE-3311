using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveManager : MonoBehaviour
{
    public int levelNum;
    public float finishTime;
    Timer timer;
    private void Start()
    {
        timer = FindObjectOfType<Timer>();

    }
    public void saveLevel()
    {
        finishTime = timer.returnTime();
        if(PlayerPrefs.GetInt("level") < levelNum)
        {
            PlayerPrefs.SetInt("level", levelNum);
            Debug.Log("Saved level number: " + PlayerPrefs.GetInt("level"));
        }
        if(PlayerPrefs.GetFloat("time" + levelNum) < finishTime)
        {
            PlayerPrefs.SetFloat("time" + levelNum, finishTime);
            Debug.Log("Saved time: " + PlayerPrefs.GetFloat("time" + levelNum));
        }
        /* (PlayerPrefs.GetInt("lastCompleted") == 7)
        {
            PlayerPrefs.SetInt("lastCompleted", 0);
        }*/
        //else
        //{
            PlayerPrefs.SetInt("lastCompleted", levelNum);
        //}
        
        
    }
}