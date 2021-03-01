using UnityEngine;
using System.Collections;

public class ChangeMessageboxText : MonoBehaviour {

	public GameObject MessageBox;
	float timer = 15f;

	public void ChangeText(string newText){
		UILabel lbl = MessageBox.GetComponent<UILabel> ();
		lbl.text = newText;
		TweenAlpha.Begin (MessageBox, 2, 255);
		timer = 15f;
	}

	void Update()
	{
		timer -= Time.deltaTime;
		if (timer < 0 && timer>-1) {
			TweenAlpha.Begin (MessageBox,10,0);
			}

	}
}
