using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update ()
    {
        // This method is called before rendering a frame
        // Most game code goes here
    }

    void FixedUpdate()
    {
        // This method is called before any physics calculations
        // Most physics code goes here

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);
    }

	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.CompareTag("Pick Up")) {
			other.gameObject.SetActive (false);
		}
	}
}