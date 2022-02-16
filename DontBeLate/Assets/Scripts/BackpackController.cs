using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackpackController : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
            ChangeScene();
        }
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(2);
    }
}
