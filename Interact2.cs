using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interact2 : MonoBehaviour {

	public float gTime=2f;
	private bool gaze=false;
	private float timer;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if (gaze) {
			timer = timer + Time.deltaTime;
		}
		if(!gaze){
			timer = 0f;
		}
		if (timer > gTime) {
			SceneManager.LoadScene ("t2");
		}
	}

	public void PointerEnter(){
		Debug.Log ("enter");
		gaze = true;
		timer = 0f;

	}

	public void PointerExit(){
		Debug.Log ("exit");
		gaze = false;
	}

}
	
