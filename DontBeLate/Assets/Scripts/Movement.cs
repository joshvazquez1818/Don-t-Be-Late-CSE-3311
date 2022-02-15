using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Movement : MonoBehaviour
{
	[SerializeField] private float speed; //adds speed adjust in unity
	private Rigidbody2D body; //applies body physics
	private Animator animate; //applies animation
	private SpriteRenderer spriteRenderer;
	private void Awake()
	{
		spriteRenderer = GetComponent<SpriteRenderer>();
		body = GetComponent<Rigidbody2D>();
		animate = GetComponent<Animator>();
	} 

	private void Update()
	{
		float horizontalinput = Input.GetAxis("Horizontal");

		body.velocity = new Vector2(horizontalinput*speed,body.velocity.y); //left right
		
		//flips player left or right 
		if(horizontalinput > 0.01f) 
		{
			spriteRenderer.flipX = false;
		}
		else if (horizontalinput < -0.01f)
		{
			spriteRenderer.flipX = true;
		}
		if(Input.GetKey(KeyCode.Space)) //jumping
		{
			body.velocity = new Vector2(body.velocity.x, speed);

		}
		animate.SetBool("run", horizontalinput != 0); //animation, run if bool is true
	}

}
