using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public Rigidbody playerRb;
    public TextSetter textSetter;
    private float dash = 0f;

	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftShift))
        {
            dash = 2f;
        }
        else if (!Input.GetKey(KeyCode.LeftShift))
        {
            dash = 0f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            playerRb.GetComponent<Rigidbody>().AddForce(0, 0, 1 + dash);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRb.GetComponent<Rigidbody>().AddForce(-1 - dash, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            playerRb.GetComponent<Rigidbody>().AddForce(0, 0, -1 - dash);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerRb.GetComponent<Rigidbody>().AddForce(1 + dash, 0, 0);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Goal"))
        {
            Debug.Log("Goal");
            textSetter.GetComponent<TextSetter>().isGoal = true;
        }
        else if (collision.gameObject.CompareTag("GameOver"))
        {
            Debug.Log("GameOver");
            textSetter.GetComponent<TextSetter>().isGameOver = true;
        }
    }
}
