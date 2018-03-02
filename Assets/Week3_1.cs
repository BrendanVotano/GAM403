using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week3_1 : MonoBehaviour {

	public int health;
	public int mana;		//Mana governs how our magic works
	public float attackPower;

	public GameObject[] enemies;

	// Use this for initialization
	void Start () 
	{
		//enemies = new GameObject[5];
		ResetValues ();
		Debug.Log (enemies.Length);

	}
	
	void ResetValues ()
	{
		health = 100;
		mana = 100;
		attackPower = 1;
	}

	int DecrementHealth(int power, int modifier)
	{
		health -= (power * modifier);
		return health;
	}

	void Update()
	{
		Controls ();

		//while (health > 0) 
		//{
		//	Debug.Log ("Player is Alive");
		//}
	}

	void SetEnemies(int enemyNumber)
	{
		enemies [enemyNumber].SetActive (false);
	}

	void EnemiesAlive()
	{
		for (int i = 0; i < enemies.Length; i++) 
		{
			enemies [i].SetActive (true);
		}

		//foreach (GameObject go in enemies)
		//	go.SetActive (true);
	}

	void Controls()
	{
		if (Input.GetKeyDown (KeyCode.H)) 
		{
			health = DecrementHealth(10,1);
		}
		if (Input.GetKeyDown (KeyCode.J)) 
		{
			health = DecrementHealth(20,2);
		}

		if (Input.GetKeyDown (KeyCode.Alpha0))
			SetEnemies (0);
		if (Input.GetKeyDown (KeyCode.Alpha1))
			SetEnemies (1);
		if (Input.GetKeyDown (KeyCode.Alpha2))
			SetEnemies (2);
		if (Input.GetKeyDown (KeyCode.Alpha3))
			SetEnemies (3);
		if (Input.GetKeyDown (KeyCode.Alpha4))
			SetEnemies (4);
		if (Input.GetKeyDown (KeyCode.Space))
			EnemiesAlive();
	}
}
