using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class DogController : MonoBehaviour
{
    private GameObject playerObject;
    Vector3 startingPos;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Destroy(gameObject);
            backToStart(collision);
        }
    }
    public void Start()
    {
        playerObject = GameObject.FindGameObjectWithTag("Player");
        startingPos = playerObject.transform.position;
    }
    public void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void backToStart(Collider2D player)
    {
        player.transform.position = startingPos;
    }
}
