using UnityEngine;
using System.Collections;

public class answers : MonoBehaviour {

	public GameObject answerbox;
	// Use this for initialization
	void OnInput(string input) {
		UILabel answer = answerbox.GetComponent<UILabel>();

		if(input == "hang")
		{
			Debug.Log ("Hanging");
		}
		Debug.Log ("Changed");
	}
}
