using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public Rigidbody2D phys;
	public int jumpSpeed = 10;

	// Use this for initialization
	void Start () {
		phys = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		jump ();
	}

	public void jump(){
		if (Input.GetKeyDown (KeyCode.Space)) {
			phys.velocity = Vector2.up * jumpSpeed;
		}
	}

	void OnCollisionEnter2D(Collision2D collision){
		Destroy(collision.gameObject);
	}
}
