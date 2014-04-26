using UnityEngine;
using System.Collections;

public class People : MonoBehaviour {
	public bool HasEmotion;
	public int Emotion;

	// Use this for initialization
	void Start () {
		HasEmotion = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public int TakeEmotion()
	{
		if(HasEmotion)
		{
			HasEmotion=false;
			return Emotion;
		}
		else return -1;
	}
}
