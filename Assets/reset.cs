using UnityEngine;
using System.Collections;

public class reset : MonoBehaviour {

	void OnClick()
	{
		PlayerPrefs.SetFloat ("saved", 0);
		Application.LoadLevel ("Act 1 Scene 1");
	}
}
