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
                SceneManager.LoadScene(3);
            }
            else if(scene.name == "Level_1_2")
            {
                SceneManager.LoadScene(4);
            }
			else if(scene.name == "Level_1_3")
            {
                SceneManager.LoadScene(5);
            }
			
			else if(scene.name == "Level_2_1")
            {
                SceneManager.LoadScene(6);
            }
			
			else if(scene.name == "Level_2_2")
            {
                SceneManager.LoadScene(7);
            }
			
			
			else if(scene.name == "Level_3_1")
            {
                SceneManager.LoadScene(8);
            }
			
			else if(scene.name == "Level_3_2")
            {
                SceneManager.LoadScene(1);
            }
			
			
        }
    }
}
