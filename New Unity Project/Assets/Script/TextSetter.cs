using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextSetter : MonoBehaviour {

    public bool isGoal = false;
    public bool isGameOver = false;

	// Update is called once per frame
	void Update () {
        if (isGoal)
        {
            // setText
            this.GetComponent<Text>().text = "Goal";
        }
        else if (isGameOver)
        {
            // setText
            this.GetComponent<Text>().text = "GameOver";
        }
	}
}
