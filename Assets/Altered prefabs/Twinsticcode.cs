/*public class movement : MonoBehaviour {
	public float moveSpeed = 1.0f;
	public float shootDelay = .2f;

	public GameObject bullet;
	public float bulletspeed = 3.0f;

	private bool canShoot = true;

	private Quaternion targetRotation;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Controls ();

		if ((Input.GetAxis ("FireHorizontal") != 0.0f || Input.GetAxis ("FireVertical") != 0.0f)  canShoot) {          
			Vector3 shootDirection = new Vector3 (Input.GetAxis ("FireHorizontal"), Input.GetAxis ("FireVertical"), 0).normalized;
			GameObject bulletInstance = Instantiate(bullet, transform.position, transform.rotation)as GameObject;
			bulletInstance.rigidbody.AddForce (shootDirection * bulletspeed, ForceMode.VelocityChange);
			canShoot = false;
			Invoke ("ShootDelay", shootDelay);

		}
	}

	void ShootDelay(){
		canShoot = true;
	}

	void Controls() {
		float horizontal = -Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
		float vertical = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;


		Vector3 moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), + Input.GetAxis ("Vertical"), 0);
		Vector3 moveAngle = new Vector3 (0, + 0, 45);
		transform.position += moveDirection * moveSpeed * Time.deltaTime;
		float angle = Mathf.Atan2 (horizontal, vertical) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler (new Vector3 (0, 0, angle));


	}
	*/