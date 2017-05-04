using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;
public class playerattack : MonoBehaviour {
	private Valve.VR.InteractionSystem.Player _player;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (_player.rightController.GetPressDown(SteamVR_Controller.ButtonMask.Trigger))
		{
			attack ();
		}
	}

	void attack(){
		Debug.Log ("homo");
		}


}
