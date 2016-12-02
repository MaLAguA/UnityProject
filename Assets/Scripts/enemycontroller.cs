using UnityEngine;
using System.Collections;

public class enemycontroller : MonoBehaviour {

	private Rigidbody myRB;
	public float moveSpeed;

	public GunControl theplayer;

	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody> ();
		theplayer = FindObjectOfType<GunControl> ();
	}

	void FixedUpdate()
	{
		myRB.velocity = (transform.forward * moveSpeed);
	}

	// Update is called once per frame
	void Update () {
		transform.LookAt (theplayer.transform.position);
	}
}
