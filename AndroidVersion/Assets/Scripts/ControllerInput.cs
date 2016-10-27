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

		if (Input.GetButtonDown("LB_1"))
		{
			inputValue = "left bumper";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("RB_1"))
		{
			inputValue = "right bumper";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("Back_1"))
		{
			inputValue = "back button";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("Start_1"))
		{
			inputValue = "start button";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("LS_1"))
		{
			inputValue = "left thumbstick button";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("RS_1"))
		{
			inputValue = "right thumbstick button";
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("R_YAxis_1")) > .2f)
		{
			inputValue = "right y-axis:\n "+ Input.GetAxis ("R_YAxis_1").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("R_XAxis_1")) > .2f)
		{
			inputValue = "right x-axis:\n "+ Input.GetAxis ("R_XAxis_1").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("L_YAxis_1")) > .2f)
		{
			inputValue = "left y-axis:\n "+ Input.GetAxis ("L_YAxis_1").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("L_XAxis_1")) > .2f)
		{
			inputValue = "left x-axis:\n "+ Input.GetAxis ("L_XAxis_1").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("DPad_XAxis_1")) > .2f)
		{
			inputValue = "DPad_XAxis:\n "+ Input.GetAxis ("DPad_XAxis_1").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("DPad_YAxis_1")) > .2f)
		{
			inputValue = "DPad_YAxis:\n "+ Input.GetAxis ("DPad_YAxis_1").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("TriggersR_1")) > .2f)
		{
			inputValue = "TriggersR_1:\n "+ Input.GetAxis ("TriggersR_1").ToString();
			textObject.text = inputValue;
		}


		if (Mathf.Abs(Input.GetAxis("TriggersL_1")) > .2f)
		{
			inputValue = "TriggersL_1:\n "+ Input.GetAxis ("TriggersL_1").ToString();
			textObject.text = inputValue;
		}
	}
}
