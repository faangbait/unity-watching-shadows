using UnityEngine;
using System.Collections;

public class ElderCollider : MonoBehaviour {
	public string Elder;
	public bool active = true;
	public GameObject ElderSprite;

	void OnTriggerEnter(Collider col){
		if (!active)
			return;

		if (col.gameObject.tag != "MainCamera")
			return;

	

		if (Elder == "Hope") {
			active=false;
			GetComponent<ChangeMessageboxText> ().ChangeText ("Your hope is the most beautiful and the saddest thing in the world...");

		}

		if (Elder == "Shame") {
			active=false;
			GetComponent<ChangeMessageboxText> ().ChangeText ("Show me a shameless person, and I will cure it for them.");

		}

		if (Elder == "Frustration") {
			active=false;
			GetComponent<ChangeMessageboxText> ().ChangeText ("To live is to suffer..");

		}

		if (Elder == "Emptiness") {
			active=false;
			GetComponent<ChangeMessageboxText> ().ChangeText ("As you go forth into emptiness, so emptiness goes into you.");
			
		}
		
		if (Elder == "Text1") {
			active=false;
			GetComponent<ChangeMessageboxText> ().ChangeText ("Are you sure this is the right direction?");
			
		}
		if (Elder == "Text2") {
			active=false;
			GetComponent<ChangeMessageboxText> ().ChangeText ("This is definitely the wrong way.");
		}
		if (Elder == "Text3") {
			active=false;
			GetComponent<ChangeMessageboxText> ().ChangeText ("And you know these words to be true...");
		}
		
		if (Elder == "Text4") {
			active=false;
			GetComponent<ChangeMessageboxText> ().ChangeText ("Your path becomes more difficult...");
		}

		if (Elder == "Text5") {
			active=false;
			GetComponent<ChangeMessageboxText> ().ChangeText ("Where do you think this will lead...");
		}
		if (Elder == "Text6") {
			active=false;
			GetComponent<ChangeMessageboxText> ().ChangeText ("Must we continue...");
		}
		if (Elder == "Text7") {
			active=false;
			GetComponent<ChangeMessageboxText> ().ChangeText ("They didn't come back. Looks like you're own your own.");
		}



	}

}
