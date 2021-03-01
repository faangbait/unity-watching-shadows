using UnityEngine;
using System.Collections;

public class LoadNextLevel : MonoBehaviour {
	public float timer = 140f;
	// Use this for initialization
	void Start()
	{
		if (PlayerPrefs.GetFloat ("saved")>0)
		{
			
			Application.LoadLevel ("Act 2 Scene 1");
		}
	}

	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer < 0) {
			GameObject.Find ("screenFader").GetComponent<SceneFadeInOut>().EndScene ("Act 1 Scene 2");
						//Application.LoadLevel ("Act 1 Scene 2");
				}
	}
}
