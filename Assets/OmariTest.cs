using UnityEngine;
using System.Collections;

public class OmariTest : LaneChanger {
	Animator m_Animator;
	Rigidbody m_Rigidbody;
	bool m_IsGrounded = true;
	 float m_JumpPower = 18f;
	public int maxHealth = 4;
	public DPadButtons dPadScript1;
	public bool recentlyHit = false;
	public float FlickerTimeInterval = 2f;
	public float playerVelocity  =10;
 	public SkinnedMeshRenderer mybodyRenderer;
	public int health;
	// Use this for initialization
	protected override void OnStart () {
		base.OnStart ();
		health = maxHealth;

		m_Animator = GetComponent<Animator>();
		m_Rigidbody = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		if (!m_IsGrounded) {
			//m_Rigidbody.velocity += (.45f*Vector3.down);
		}
	}
	void Update () {	
		if (GameManager.LevelRunning) {
			m_Rigidbody.transform.position = new Vector3 (transform.position.x, transform.position.y, curZ);
			m_Rigidbody.velocity = new Vector3 (playerVelocity, m_Rigidbody.velocity.y, m_Rigidbody.velocity.z);
			gameObject.transform.rotation = Quaternion.Euler (0, 90, 0);
		
			m_Animator.SetFloat ("Forward", 1);
		}

		//m_Animator.SetFloat("Turn", 5.364419e-07f);
		if (Input.GetButtonDown ("Jump")) {
			if (m_IsGrounded) {
				m_IsGrounded = false;
				//m_Animator.SetBool("OnGround", m_IsGrounded); //when used with animation jump velocity is being cut harshly
				m_Rigidbody.velocity = new Vector3 (m_Rigidbody.velocity.x, m_JumpPower, m_Rigidbody.velocity.z);
			}
		}
		if (dPadScript1.UpPressed ()) {
			MoveUp ();
		}
		else if (dPadScript1.DownPressed())
		{
			MoveDown();
		}


	}
	public void ChangeHealth(int changeInhealth)
	{
		health += changeInhealth;
		if (health < 0) {
			health = 0;
		}
		if (health > maxHealth) {
			health = maxHealth;
		}
		Debug.Log ("Changing Health by: " + changeInhealth);
	}

	void StartFlicker()
	{
		StartCoroutine (Flickering ());

	}

	IEnumerator Flickering()
	{
		float time = 0f;
		while (time < FlickerTimeInterval) {
			mybodyRenderer.enabled = !mybodyRenderer.enabled;
			yield return new WaitForSeconds (.1f);
			time += .1f;
		}
		mybodyRenderer.enabled = true;
		recentlyHit = false;
	}
	void OnCollisionEnter(Collision col)
	{
		//Debug.Log("what did playre hit: " + col.gameObject.name);
		if (col.gameObject.name == "ground") {
			m_IsGrounded = true;
			//m_Animator.SetBool("OnGround", m_IsGrounded);
			//m_Rigidbody.velocity = new Vector3(10,0,m_Rigidbody.velocity.z);
			//transform.position = new Vector3 (transform.position.x, 10,curZ);
		}
	}
}
