using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextOverObject : MonoBehaviour {


	//public string current_text;
	public Text text_field;
	public bool isEnabled;

	// Use this for initialization
	public void Start () 
	{
		text_field = GameObject.Find ("Text").GetComponent<Text> ();
		text_field.color = Color.clear;
		Debug.Log ("I recognized text in model");
		doText ();
	}

	public void doText()
	{
		if (Input.GetMouseButtonDown (0))
			isEnabled = true;
		if (isEnabled) 
		{
			Debug.Log ("I recognized click");
			text_field.text = "0" + "%";
			text_field.color = Color.red;

		}
	}


}
