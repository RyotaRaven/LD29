using UnityEngine;
using System.Collections;


public class SeeHeart : MonoBehaviour 
{
	public MeshRenderer[] hidden;
	public bool CanTake;
	public bool Holding;
	public bool close;
	public MeshRenderer[] orb;
	// Use this for initialization
	void Start () 
	{
		close = false;
	}

	void OnTriggerEnter(Collider stuff)
	{
		if(stuff.tag=="People")
		{
			Debug.Log("TRIGGER");
			close=true;
		}
	}

	void OnTriggerExit(Collider stuff)
	{
		if(stuff.tag=="People")
		{
			Debug.Log("END TRIGGER");
			//close=false;
		}
	}

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			foreach(MeshRenderer m in hidden)
			{

				m.enabled= !m.enabled;
				if(m.enabled==true)
				{
					CanTake=false;
				}
				else
					CanTake=true;
			}

		}
		if (Input.GetKeyDown(KeyCode.Return) && CanTake && !Holding) 
		{
			Debug.Log (close);
			if(close)
			{
				Debug.Log ("Take");
				CanTake=false;
				Holding=true;
				foreach(MeshRenderer x in orb)
				{
					x.enabled= true;
				}
			}
		}

	}
	
}
