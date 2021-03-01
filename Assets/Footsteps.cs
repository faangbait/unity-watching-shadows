using UnityEngine;
using System.Collections;

public class Footsteps : MonoBehaviour {
	public AudioClip AudioFile;

	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.W))
		{
			audio.clip = AudioFile;
			audio.Play ();
			
		}
		
		if(Input.GetKey(KeyCode.S))
		{
			audio.clip = AudioFile;
			audio.Play ();

		}
	}
}
