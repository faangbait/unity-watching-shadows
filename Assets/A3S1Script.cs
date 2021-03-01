using UnityEngine;
using System.Collections;

public class A3S1Script : MonoBehaviour {
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
				newText="Hi again...\n\nAre you still lost?";
				timer = 5f;

			break;

			case 2:
				newText="Hi again...\n\nAre you still lost?\n\nNo?";
				timer = 5f;
			break;

			case 3:
				newText="Hi again...\n\nAre you still lost?\n\nNo?\n\nAre you enlightened now?";
				timer = 5f;
				break;
			
			case 4:
				newText="\n\nHave you learned \nall you need to know?";
				timer=10f;
				break;
				
			case 5:
				newText="\nYou wandered too deeply into our woods. \n\nYou faced your shadows of fear, hopelessness, shame, frustration, and emptiness.";
				timer=10f;
				break;

			case 6:
				newText="But to be enlightened is to conquer a final shadow:\n\n ego.";
				timer=15f;
				break;

			case 7:
				newText="But the ego cannot be conquered. If you try to conquer it, you will attain a certain subtle ego again which says, 'I have conquered my ego.'";
				timer=15f;
			break;
			case 8:
				newText="Try to see your own ego. \n\nJust watch it. \nSuddenly, one day, you simply see that it has dropped. It just drops like a dead leaf.";
				timer=15f;
				break;
			case 9:
				newText ="It settles into the ground, dies of its own accord. You have not done anything so you cannot claim that you have dropped it. \n\nIt has disappeared.";
				timer=15f;
				break;
			case 10:
				newText="\nWhat is left is the real center. The soul, the self, the god, the truth, or whatsoever you call it. It is nameless, so all names are good.";
				timer=15f;
				break;
			case 11:
				newText="\n\nYou can give it \n\nany name you like.";
				timer=25f;
				break;
			}


			if(i<12)
			{
			i+=1;
			lbl.GetComponent<UILabel>().text = newText;
			}
		}
	}
}
