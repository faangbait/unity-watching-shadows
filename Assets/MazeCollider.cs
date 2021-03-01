using UnityEngine;
using System.Collections;

public class MazeCollider : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag != "MainCamera")
						return;
		GetComponent<ChangeMessageboxText> ().ChangeText ("A maze of towering trees, all alike.");
	}
}
