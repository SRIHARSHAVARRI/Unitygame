using UnityEngine;

public class playermovement : MonoBehaviour {
    public Rigidbody rb;
	// Use this for initialization
    public float forwardforce=1000f;
    public float sidewaysForce = 500f;
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0,forwardforce*Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce* Time.deltaTime, 0, 0,ForceMode.VelocityChange);

        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce* Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<gameManager>().EndGame();
        }


    }
}
