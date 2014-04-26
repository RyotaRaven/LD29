using UnityEngine;
using System.Collections;


public class SeeHeart : MonoBehaviour 
{
	public MeshRenderer[] hidden;
	public bool CanTake;
	public bool Holding;
	public bool close;
	public bool CanPut;
	public MeshRenderer[] orb;
	private int CurrentEmotion;
	private People person;
	private Sparkles hold;
	public Material[] Emotions;
	// Use this for initialization
	void Start () 
	{
		close = false;
	}

	void OnTriggerEnter(Collider stuff)
	{
		if(stuff.tag=="People")
		{
			close=true;
			person=stuff.GetComponent<People>();
		}
		if(stuff.tag=="Holder")
		{
			CanPut=true;
			hold=stuff.GetComponent<Sparkles>();
		}
	}

	void OnTriggerExit(Collider stuff)
	{
		if(stuff.tag=="People")
		{
			close=false;
			person=null;
		}
		if(stuff.tag=="Holder")
		{
			CanPut=false;
			hold=null;
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
			if(close)
			{
				CanTake=false;
				Holding=true;
				foreach(MeshRenderer x in orb)
				{
					CurrentEmotion=person.TakeEmotion();
					if(CurrentEmotion!=-1)
					{
						x.enabled= true;
						x.material=Emotions[CurrentEmotion];
						foreach(MeshRenderer m in hidden)
						{
							
							m.enabled= !m.enabled;
						}
					}
				}
			}
		}
		if (Input.GetKeyDown(KeyCode.Return) && CanPut && Holding) 
		{
			bool put=false;
			Holding=false;
			foreach(MeshRenderer x in orb)
			{
				put=hold.HoldEmotion(CurrentEmotion);
				if(put)
				{
					x.enabled=false;
				}
				else Holding=true;
			}
		}

	}
	
}
