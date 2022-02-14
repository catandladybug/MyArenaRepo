using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeBaseBehavior : MonoBehaviour
{

	public bool hasFlag = false;
	public GameObject flag;
	private BlueFlagBehavior bool_script;
	private void Start()
	{
		bool_script = flag.GetComponent<BlueFlagBehavior>();
	}
	private void Update()
	{
		if(bool_script.hasBlueFlag = true);
        {
			hasFlag = true;
        }
	}

	void OnCollisionEnter(Collision collision)
	
	{
		if(collision.gameObject.name == "Player");
		{
			if (hasFlag = true) ;
			{
				Debug.Log("You win!");

				hasFlag = false;
			}
		}
	}
}
