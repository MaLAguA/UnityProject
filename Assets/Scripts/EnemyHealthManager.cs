using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyHealthManager : MonoBehaviour {

	public int health;
	public int currentHealth;
	[SerializeField]
	Image UIhealth;
	// Use this for initialization
	void Start () {
		currentHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
		UIhealth.fillAmount = (int)currentHealth / (int)health;		
		if (currentHealth <= 0) {
			Destroy (gameObject);

		}
	}

	public void HurtEnemy(int damage)
	{
		currentHealth -= damage;
	}
}
