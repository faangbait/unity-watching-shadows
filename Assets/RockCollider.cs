using UnityEngine;
using System.Collections;

public class RockCollider : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag != "MainCamera")
			return;

		GetComponent<ChangeMessageboxText> ().ChangeText ("Not as heavy as it looks.");
	}
}
