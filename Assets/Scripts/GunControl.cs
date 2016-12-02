using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class GunControl : MonoBehaviour {


	public bool isFiring;
	public BulletControl bullet;
	public float bulletspeed;

	public float timeBetweenShots;
	private float shotCounter;

	public Transform firepoint;

	[SerializeField]
	Animator myanimator;
	[SerializeField]
	AudioSource myaudiosource;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButtonDown("Fire1"))
			{
				myanimator.SetTrigger("Shoot");
			}
		if (isFiring) {
			shotCounter -= Time.deltaTime;
			if (shotCounter <= 0) {
				shotCounter = timeBetweenShots;
				BulletControl newbullet = Instantiate (bullet, firepoint.position, firepoint.rotation) as BulletControl;
				newbullet.speed = bulletspeed;
			}
		}
		else{
			shotCounter = 0;
		}
	}
}
