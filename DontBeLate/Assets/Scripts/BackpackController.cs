using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackpackController : MonoBehaviour
{   
    public Scene scene = SceneManager.GetActiveScene();
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
            if(scene.name == "Level_1_1")
            {
                SceneManager.LoadScene("Level_1_2");
            }
        }
    }
}
