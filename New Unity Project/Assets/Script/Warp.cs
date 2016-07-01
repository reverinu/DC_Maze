using UnityEngine;
using System.Collections;

public class Warp : MonoBehaviour {

    public GameObject player;
    public Vector3 warpPos;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            player.transform.position = warpPos;
        }
    }
}
