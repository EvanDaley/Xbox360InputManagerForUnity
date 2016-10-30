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
		if (InputMapper.GetValue("button0") == 1)
		{
			inputValue = "button0";
			textObject.text = inputValue;
		}

		if (InputMapper.GetValue("button1") == 1)
		{
			inputValue = "button1";
			textObject.text = inputValue;
		}

		if (InputMapper.GetValue("button2") == 1)
		{
			inputValue = "button2";
			textObject.text = inputValue;
		}

		if (InputMapper.GetValue("button3") == 1)
		{
			inputValue = "button3";
			textObject.text = inputValue;
		}

		if (InputMapper.GetValue("button4") == 1)
		{
			inputValue = "button4";
			textObject.text = inputValue;
		}

		if (InputMapper.GetValue("button5") == 1)
		{
			inputValue = "button5";
			textObject.text = inputValue;
		}

		if (InputMapper.GetValue("button6") == 1)
		{
			inputValue = "button6";
			textObject.text = inputValue;
		}

		if (InputMapper.GetValue("button7") == 1)
		{
			inputValue = "button7";
			textObject.text = inputValue;
		}

		if (InputMapper.GetValue("button8") == 1)
		{
			inputValue = "button8";
			textObject.text = inputValue;
		}

		if (InputMapper.GetValue("button9") == 1)
		{
			inputValue = "button9";
			textObject.text = inputValue;
		}

		if (InputMapper.GetValue("button10") == 1)
		{
			inputValue = "button10";
			textObject.text = inputValue;
		}

		if (InputMapper.GetValue("button1") == 1)
		{
			inputValue = "button1";
			textObject.text = inputValue;
		}

		if (InputMapper.GetValue("button11") == 1)
		{
			inputValue = "button11";
			textObject.text = inputValue;
		}

		if (InputMapper.GetValue("button12") == 1)
		{
			inputValue = "button12";
			textObject.text = inputValue;
		}

		if (InputMapper.GetValue("button13") == 1)
		{
			inputValue = "button13";
			textObject.text = inputValue;
		}

		if (Mathf.Abs(InputMapper.GetValue("axis1")) > .2f)
		{
			inputValue = "axis1:\n "+ Input.GetAxis ("axis1").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(InputMapper.GetValue("axis2")) > .2f)
		{
			inputValue = "axis2:\n "+ Input.GetAxis ("axis2").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(InputMapper.GetValue("axis3")) > .2f)
		{
			inputValue = "axis3:\n "+ Input.GetAxis ("axis3").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(InputMapper.GetValue("axis4")) > .2f)
		{
			inputValue = "axis4:\n "+ Input.GetAxis ("axis4").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(InputMapper.GetValue("axis5")) > .2f)
		{
			inputValue = "axis5:\n "+ Input.GetAxis ("axis5").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(InputMapper.GetValue("axis6")) > .2f)
		{
			inputValue = "axis6:\n "+ Input.GetAxis ("axis6").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(InputMapper.GetValue("axis7")) > .2f)
		{
			inputValue = "axis7:\n "+ Input.GetAxis ("axis7").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(InputMapper.GetValue("axis8")) > .2f)
		{
			inputValue = "axis8:\n "+ Input.GetAxis ("axis8").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(InputMapper.GetValue("axis9")) > .2f)
		{
			inputValue = "axis9:\n "+ Input.GetAxis ("axis9").ToString();
			textObject.text = inputValue;
		}

		if (Mathf.Abs(InputMapper.GetValue("axis10")) > .2f)
		{
			inputValue = "axis10:\n "+ Input.GetAxis ("axis10").ToString();
			textObject.text = inputValue;
		}
	}
}