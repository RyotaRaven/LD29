using UnityEngine;
using System.Collections;


public class Unlock : MonoBehaviour {
	
	public Transform[] Triggers;
	public MeshRenderer[] Obstacle;
	private int count;
	private int toOpen;
	private bool[] canOpen;
	public GameObject[] wall;
	private bool Open;

	// Use this for initialization
	void Start () { 
		canOpen = new bool[Triggers.Length];
	}
	
	// Update is called once per frame
	void Update () 
	{
		for (int i=0; i<canOpen.Length; i++)
			canOpen [i] = Triggers [i].GetComponent<Sparkles> ().Triggered;
		if(canOpen.Length>=2)
		{
			Open=canOpen[0] && canOpen[1];
			for(int x=2; x<canOpen.Length; x++)
			{
				Open= Open &&canOpen[x];
			}
		}
		else
			Open=canOpen[0];
		if (Open)
		{
			foreach(MeshRenderer m in Obstacle)
			{
				m.enabled=false;
			}
			foreach(GameObject o in wall)
			{
				o.collider.isTrigger=true;
			}
		}
	}
}
