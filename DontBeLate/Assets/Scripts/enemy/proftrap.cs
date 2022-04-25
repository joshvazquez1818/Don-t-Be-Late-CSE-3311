using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proftrap : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
	[SerializeField] private Transform profPoint;
	[SerializeField] private GameObject[] attack;
	private float cooltimer;
	
	private void Attack()
	{
		cooltimer = 0;
		attack[FindAttack()].transform.position = profPoint.position;
		attack[FindAttack()].GetComponent<EnemyProjectile>().ActivateProjectile();
		 
	}

	private int FindAttack()
	{
		for(int i = 0; i < attack.Length; i++)
		{
			if (!attack[i].activeInHierarchy)
			{
				return i;
			}
		}
		return 0;
		
	}
	

	private void Update()
	{
		cooltimer += Time.deltaTime;
		if(cooltimer >= attackCooldown)
		{
			Attack();
		}
		
	}
}

