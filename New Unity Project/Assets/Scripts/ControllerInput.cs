using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ControllerInput : MonoBehaviour {

	public string inputValue = "Please connect controller and press button";
	public Text textObject;

	void Start ()
	{
		textObject.text = inputValue;
	}
	
	void Update () 
	{
		if (Input.GetAxis (""))
		{

		}
	}
}
