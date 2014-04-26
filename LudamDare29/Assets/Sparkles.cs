using UnityEngine;
using System.Collections;

public class Sparkles : MonoBehaviour {

	public int RequiredEmotion;
	public Material myEmotion;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public bool HoldEmotion(int PutEmotion)
	{
		if(PutEmotion==RequiredEmotion)
		{
			renderer.material=myEmotion;
			return true;
		}
		else return false;
	}

}
