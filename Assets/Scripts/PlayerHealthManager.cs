using UnityEngine;
using System.Collections;

public class PlayerHealthManager : MonoBehaviour {

	public int StartingHealth;
	public int CurrentHealth;
	public bool Havetakendamage;
	[SerializeField]
	float Havetakendamagetimer;
	float timer = 0;

	// Use this for initialization
	void Start () {
		CurrentHealth = StartingHealth;
	}
	
	// Update is called once per frame
	void Update () {
		if (CurrentHealth <= 0) {
			gameObject.SetActive (false);


		}

		timer += Time.deltaTime;

	}

	public void HurtPlayer(int damageAmmount){
		if (timer >= Havetakendamagetimer) {
			CurrentHealth -= damageAmmount;
			timer = 0;
		}
	}
}
