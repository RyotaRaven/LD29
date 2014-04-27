using UnityEngine;
using System.Collections;

public class Win : MonoBehaviour {
	
	void OnTriggerEnter(Collider blah)
	{
		Application.LoadLevel ("Win");
	}

}
