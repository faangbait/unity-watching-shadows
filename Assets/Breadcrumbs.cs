using UnityEngine;
using System.Collections;

public class Breadcrumbs : MonoBehaviour {
	public TrailRenderer bread;

	void OnClick()
	{
		if (bread.enabled == true)
						bread.enabled = false;
				else
						bread.enabled = true;
	}
}
