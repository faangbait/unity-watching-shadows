using UnityEngine;
using System.Collections;

public class AutoSave : MonoBehaviour {
	public float timer = 60f;
	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetFloat ("saved")>0)
		{

			transform.position = new Vector3(PlayerPrefs.GetFloat("x"),PlayerPrefs.GetFloat("y"),PlayerPrefs.GetFloat("z"));
		}
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer < Time.deltaTime) {
						SaveSettings ();
						timer = 60f;
				}
	}

	void SaveSettings()
	{
		Debug.Log ("Progress saved.");
		PlayerPrefs.SetFloat ("x", transform.position.x);
		PlayerPrefs.SetFloat ("y", transform.position.y);
		PlayerPrefs.SetFloat ("z", transform.position.z);
		PlayerPrefs.SetFloat ("saved", 1f);
	}
}
