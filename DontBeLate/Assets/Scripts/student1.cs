using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class student1 : MonoBehaviour {
	public float distance = 4;
	Animator anim;
	public GameObject player;
	public GameObject student;
	public Rigidbody2D body; //applies body physics
	//Vector3 temp = ;
	
	void Start(){
		player = GameObject.FindGameObjectWithTag ("Player");
		body = player.GetComponent<Rigidbody2D>();
		student = GameObject.Find("student1"); 
		anim = student.GetComponent<Animator>();
        Physics2D.queriesStartInColliders = false;
	}
	

	void Update()
	{
		if(anim.GetCurrentAnimatorStateInfo(0).IsName("student1look"))
		{

			RaycastHit2D hitInfo = Physics2D.Raycast(transform.position, (-transform.right), distance);

			if(hitInfo.collider != null){
				Debug.DrawLine(transform.position, hitInfo.point, Color.red);
			
				if(hitInfo.collider.CompareTag("Player")){

					GetComponent<Animator>().Play("student1saw");
					
					
				}
			
			}else
			{
				Debug.DrawLine(transform.position, transform.position + (-transform.right) * distance, Color.green);
			}
		}
		if(anim.GetCurrentAnimatorStateInfo(0).IsName("student1saw"))
		{
			
			//body.constraints = RigidbodyConstraints2D.FreezePositionX ;
			//body.constraints = RigidbodyConstraints2D.FreezePositionY ;
			
			body.constraints &= ~RigidbodyConstraints2D.FreezePositionX;
			body.constraints &= ~RigidbodyConstraints2D.FreezePositionY; 
			new WaitForSeconds(6f); 
			player.transform.position = new Vector3(-8f,-.6f,0f);
		}
	}	
	
}
