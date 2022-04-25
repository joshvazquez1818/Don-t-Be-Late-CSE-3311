using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackpackController : MonoBehaviour
{   
    public Scene scene;
    public SaveManager savemanager;
    public void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            savemanager.saveLevel();
            Destroy(gameObject);
            SceneManager.LoadScene(10);
            
        }
    }
}
