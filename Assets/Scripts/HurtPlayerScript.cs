using UnityEngine;
using System.Collections;

public class HurtPlayerScript : MonoBehaviour {

	public int damageToGive;
	public int damagetimer;

	public void OnTriggerStay(Collider other)
	{
		if (other.gameObject.tag == "Player") {
			other.gameObject.GetComponent<PlayerHealthManager> ().HurtPlayer (damageToGive);
		}
	}
}
