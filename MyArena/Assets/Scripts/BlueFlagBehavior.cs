using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueFlagBehavior : MonoBehaviour

{
	public bool hasBlueFlag = false;
	
	void OnCollisionEnter(Collision collision)
	
	{
		if(collision.gameObject.name == "Player")
		{
			Destroy(this.transform.parent.gameObject);
			
			Debug.Log("Flag Collected!");
			
			hasBlueFlag = true;

			PlayerBehavior Player = collision.gameObject.GetComponent<PlayerBehavior>();

			Player.ShowHat();

		}
	}
}

