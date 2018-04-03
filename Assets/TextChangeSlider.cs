using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextChangeSlider: MonoBehaviour {

	public Text text_field;
	public string sliderString;

	void Start () 
	{
		text_field = GameObject.Find ("Text").GetComponent<Text> ();
		//Debug.Log ("I recognized text object in slider");
	}

	public void changeText(float value)
	{
		

		//sliderString = Mathf.RoundToInt (value * 100).ToString() + "%";
		//Debug.Log (sliderString);
		//text_field.text = sliderString;

		if (value >= 1940f && value < 1960f)
		{
			text_field.text = "Hi from 1940 to 1960!";
		} 
		else if (value >= 1960f && value < 1980f ) {
			text_field.text = "Hi from 1960 to 1980!";
		}
		else 
		{
			text_field.text = "Hi! From everywhere" ;
		}
		text_field.color = Color.white;

	}
}
