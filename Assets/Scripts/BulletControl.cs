using UnityEngine;
using System.Collections;

public class BulletControl : MonoBehaviour {

	public float speed;
	public float timer;
	public int damageToGive;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, timer);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * speed * Time.deltaTime);

	}

	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Enemy") {
			other.gameObject.GetComponent<EnemyHealthManager> ().HurtEnemy (damageToGive);
			Destroy (gameObject);
		}
	}
}
