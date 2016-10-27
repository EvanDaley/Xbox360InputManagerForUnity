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
		if (Input.GetButtonDown("A_1"))
		{
			inputValue = "a button";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("B_1"))
		{
			inputValue = "b button";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("X_1"))
		{
			inputValue = "x button";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("Y_1"))
		{
			inputValue = "y button";
			textObject.text = inputValue;
		}
	}
}
