using UnityEngine;
using System.Collections;

public class Backpack : MonoBehaviour {
	public UIPopupList BackpackContents;
	public string LastValue;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void OnSelect () {
		if (LastValue!=BackpackContents.value)
			{
			Debug.Log("Selection: " + BackpackContents.value);
			LastValue=BackpackContents.value;
		}
	}

}

