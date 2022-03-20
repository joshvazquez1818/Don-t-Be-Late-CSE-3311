using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackpackController : MonoBehaviour
{   
    public Scene scene;
    public void Start()
    {
        scene = SceneManager.GetActiveScene();
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
            if(scene.name == "Level_1_1")
            {
                SceneManager.LoadScene(4);
            }
            else if(scene.name == "Level_1_2")
            {
                SceneManager.LoadScene(2);
            }
			else if(scene.name == "Level_1_3")
            {
                SceneManager.LoadScene(2);
            }
        }
    }
}
