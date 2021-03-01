using UnityEngine;
using System.Collections;

public class StartLaughter : MonoBehaviour {
	public float timeToStart = 5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeToStart = timeToStart - Time.deltaTime;

		if (timeToStart < 0) {
			this.audio.enabled= true;

			}
	}
}
