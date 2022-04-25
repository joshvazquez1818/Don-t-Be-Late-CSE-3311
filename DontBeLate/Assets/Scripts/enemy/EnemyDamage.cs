using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyDamage : MonoBehaviour
{
	public GameObject player;
    [SerializeField] protected float damage;
	
	void Start(){
		player = GameObject.FindGameObjectWithTag ("Player");
		
	}
	
	protected void OnTriggerEnter2D(Collider2D collision)
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
