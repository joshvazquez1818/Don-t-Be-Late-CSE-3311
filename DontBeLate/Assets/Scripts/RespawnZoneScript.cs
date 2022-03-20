using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RespawnZoneScript : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            ChangeScene();
        }
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
