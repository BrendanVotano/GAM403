using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Week3 : MonoBehaviour {

	public int health;
	public int mana;	//Mana is used by our magic system 
	public float attackPower;
	public float defencePower;

	public GameObject player;

	[Header("Enemy Variables")]
	public GameObject[] enemies;
	public int[] enemyHitPoints;

	public int enemyNumb;

	// Use this for initialization
	void Start () 
	{
		ResetCharacter ();
	}

	//Sets all our characters values to default
	void ResetCharacter()
	{
		health = 100;
		mana = 100;
		attackPower = 10;
		defencePower = 5;
	}

	void DecrementHealth()
	{
		health -= 10;
	}

	int MinusHealth(int power, int modifier)
	{
		return health -= (power * modifier);
	}

	void KillEnemy(int enemyNumber)
	{
		enemies [enemyNumber].SetActive (false);
	}

	void ShowEnemyName(int enemyNumber)
	{
		Debug.Log (enemies [enemyNumber].name);
	}

	void SpawnEnemies()
	{
		enemies [0].SetActive (true);
		enemies [1].SetActive (true);
		enemies [2].SetActive (true);
		enemies [3].SetActive (true);
		enemies [4].SetActive (true);
		enemies [5].SetActive (true);
	}

	void KillAllEnemies()
	{
		enemies [0].SetActive (false);
		enemies [1].SetActive (false);
		enemies [2].SetActive (false);
		enemies [3].SetActive (false);
		enemies [4].SetActive (false);
		enemies [5].SetActive (false);
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.S))
			SpawnEnemies();
		
		if (Input.GetKeyDown (KeyCode.K))
			KillEnemy (enemyNumb);

		if (Input.GetKeyDown (KeyCode.A))
			KillAllEnemies ();

		if (Input.GetKeyDown (KeyCode.H))
			DecrementHealth ();

		if (Input.GetKeyDown (KeyCode.Alpha1))
			health = MinusHealth(50,2);//Ogre strength
		
		if (Input.GetKeyDown (KeyCode.Alpha2))
			health = MinusHealth(30,2);//Elf strength
		
		if (Input.GetKeyDown (KeyCode.Alpha0))
			health = MinusHealth(10,2);//Dwarf strength
	}
}
