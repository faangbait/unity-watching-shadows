using UnityEngine;
using System.Collections;

public class CarCollider : MonoBehaviour {

	void OnTriggerStay(Collider col){
		if (col.gameObject.tag != "MainCamera")
			return;
		Camera.main.GetComponent<CharacterMovement> ().enabled = false;
		Camera.main.transform.rigidbody.velocity = new Vector3(0,0,.1f);
		GameObject.Find ("screenFader").GetComponent<SceneFadeInOut>().EndScene ("Act 3 Scene 1");
	}
}
