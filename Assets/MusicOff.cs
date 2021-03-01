using UnityEngine;
using System.Collections;

public class MusicOff : MonoBehaviour {

	public AudioSource music;
	
	void OnClick()
	{
		if (music.mute == true)
			music.mute = false;
		else
			music.mute = true;
	}
}

