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
		if (Input.GetButtonDown("button0"))
		{
			inputValue = "button0";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("button1"))
		{
			inputValue = "button1";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("button2"))
		{
			inputValue = "button2";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("button3"))
		{
			inputValue = "button3";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("button4"))
		{
			inputValue = "button4";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("button5"))
		{
			inputValue = "button5";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("button6"))
		{
			inputValue = "button6";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("button7"))
		{
			inputValue = "button7";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("button8"))
		{
			inputValue = "button8";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("button9"))
		{
			inputValue = "button9";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("button10"))
		{
			inputValue = "button10";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("button1"))
		{
			inputValue = "button1";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("button11"))
		{
			inputValue = "button11";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("button12"))
		{
			inputValue = "button12";
			textObject.text = inputValue;
		}

		if (Input.GetButtonDown("button13"))
		{
			inputValue = "button13";
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("axis1")) > .2f)
		{
			inputValue = "axis1:\n "+ Input.GetAxis ("axis1").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("axis2")) > .2f)
		{
			inputValue = "axis2:\n "+ Input.GetAxis ("axis2").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("axis3")) > .2f)
		{
			inputValue = "axis3:\n "+ Input.GetAxis ("axis3").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("axis4")) > .2f)
		{
			inputValue = "axis4:\n "+ Input.GetAxis ("axis4").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("axis5")) > .2f)
		{
			inputValue = "axis5:\n "+ Input.GetAxis ("axis5").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("axis6")) > .2f)
		{
			inputValue = "axis6:\n "+ Input.GetAxis ("axis6").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("axis7")) > .2f)
		{
			inputValue = "axis7:\n "+ Input.GetAxis ("axis7").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("axis8")) > .2f)
		{
			inputValue = "axis8:\n "+ Input.GetAxis ("axis8").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("axis9")) > .2f)
		{
			inputValue = "axis9:\n "+ Input.GetAxis ("axis9").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(Input.GetAxis("axis10")) > .2f)
		{
			inputValue = "axis10:\n "+ Input.GetAxis ("axis10").ToString();
			textObject.text = inputValue;
		}
	}
}