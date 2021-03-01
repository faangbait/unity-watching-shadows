using UnityEngine;
using System.Collections;

public class A1S2Script : MonoBehaviour {
	public float timer = 10f;
	private int i = 1;
	private string newText;
	public UILabel lbl;
	public GameObject Elder;
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer < 0) {

			switch(i)
			{
			case 1:
				newText="Hi there...\n\nAre you lost?";
				timer = 5f;

			break;

			case 2:
				newText="Hi there...\n\nAre you lost?\n\nYou seem lost...";
				timer = 5f;
			break;

			case 3:
				newText="Hi there...\n\nAre you lost?\n\nYou seem lost...\n\nWill you come with me?";
				timer = 5f;
				break;
			
			case 4:
				newText="We are going to be good friends, you and I.";
				timer=10f;
				break;
				
			case 5:
				newText="\nYou wandered too deeply into our woods. \n\nAll you will know until the day you die are shadows.";
				timer=10f;
				break;

			case 6:
				newText="Most people think that shadows follow objects. \n\nThe truth is that they also follow words, ideas, desires, deeds, impulses and memories.";
				timer=20f;
				break;

			case 7:
				newText="When you wake, you will set off into the forest in search of an exit, \n\nbut all you will find...";
				timer=5f;
			break;
			case 8:
				newText="When you wake, you will set off into the forest in search of an exit, \n\nbut all you will find...\nare more shadows....";
				timer=10f;
				break;
			case 9:
				GameObject.Find ("screenFader").GetComponent<SceneFadeInOut>().EndScene ("Act 2 Scene 1");
				break;
			}


			if(i<9)
			{
			i+=1;
			lbl.GetComponent<UILabel>().text = newText;
			}
		}
	}
}
