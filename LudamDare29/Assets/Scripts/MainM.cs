using UnityEngine;
using System.Collections;

public class MainM : MonoBehaviour {

	public Material[] Load;
	public MeshRenderer[] Graphic;
	private bool Loading;
	private bool Instructions;
	// Use this for initialization
	void OnGUI () {
		if(!Loading && !Instructions)
		{
			if (GUI.Button (new Rect (Screen.width/3-75,Screen.width/5, 100, 30), "Play")) {
				Loading=true;
				Graphic[0].material= Load[1];
				Application.LoadLevel("World");
			}
			if (GUI.Button (new Rect (Screen.width/3-75,Screen.width/5+50, 100, 30), "Instructions")) {
				Graphic[0].material= Load[2];
				Instructions=true;
			}
		}
		if(Instructions)
		{
			if (GUI.Button (new Rect (Screen.width/2-50,Screen.height-50, 100, 30), "Back")) {
				Instructions=false;
				Graphic[0].material= Load[0];
			}
		}
	}
}
