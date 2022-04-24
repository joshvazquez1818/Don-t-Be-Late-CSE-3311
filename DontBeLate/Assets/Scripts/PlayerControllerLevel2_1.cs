using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerLevel2_1 : MonoBehaviour
{
	[SerializeField] private float speed; //adds speed adjust in unity
	private Rigidbody2D body; //applies body physics
	private Animator animate; //applies animation
	private SpriteRenderer spriteRenderer;

	private bool ground;

	public Energy_Bar_Behavior energyBar;
	private int maxEnergy = 100;
	public int currentEnergy;
	private float currentWakeClicks = 0;
	public float maxWakeClicks = 10;

	
	private void Awake()
	{
		InvokeRepeating("DecrementEnergy", 0.0f, 1.0f);
		spriteRenderer = GetComponent<SpriteRenderer>();
		body = GetComponent<Rigidbody2D>();
		animate = GetComponent<Animator>();
		currentEnergy = maxEnergy;
		energyBar.SetMaxEnergy(maxEnergy);
	}

	private void Update()
	{
		energyBar.SetEnergy(currentEnergy);
		// Only allow movement if player is awake
		if(currentEnergy > 0)
        {
			currentWakeClicks = 0;
			float horizontalinput = Input.GetAxis("Horizontal");

			body.velocity = new Vector2(horizontalinput * speed, body.velocity.y); //left right
																				   //flips player left or right 
			if (horizontalinput > 0.01f)
			{
				spriteRenderer.flipX = false;
			}
			else if (horizontalinput < -0.01f)
			{
				spriteRenderer.flipX = true;
			}
			if (Input.GetKey(KeyCode.Space) && ground) 
			{
				jump();
			}
			animate.SetBool("run", horizontalinput != 0); //animation, run if bool is true
			animate.SetBool("ground", ground);
		}

		else
        {
			// Wake up player after maxWakeClicks left mouse clicks
            if (Input.GetMouseButtonDown(0))
            {
				currentWakeClicks++;
			}
			if(currentWakeClicks >= maxWakeClicks)
            {
				currentEnergy = 50;
            }
		}


	}
	void DecrementEnergy()
    {
		currentEnergy -= 5;
    }
	private void jump()
	{
		body.velocity = new Vector2(body.velocity.x, speed);
		animate.SetTrigger("jump");
		ground = false;
	}

	//checks if player is on the ground/platform
	private void OnCollisionEnter2D(Collision2D other)
	{
		if(other.gameObject.CompareTag("Ground"))
		{
			 ground = true;
		}
	}
	public void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Coffee")
		{
			if(currentEnergy <= 50)
            {
				currentEnergy += 50;
			}
			else
            {
				currentEnergy = 100;
            }
		}
	}

}
