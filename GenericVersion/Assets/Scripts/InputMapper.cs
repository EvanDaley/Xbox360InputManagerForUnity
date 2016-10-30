using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InputMapper : MonoBehaviour {

	public InputButton[] buttons;
	public InputAxis[] axis;

	void Start () 
	{
		// load preferences
	}
	
	void Update () 
	{
	
	}

	/// <summary>
	/// Gets the state of the selected input from -1 to 1. Nonpressed button: 0. Pressed button: 1.
	/// </summary>
	/// <returns>The input value.</returns>
	/// <param name="button">Button.</param>
	public static float GetValue(string input)
	{
		
	}
}

[System.Serializable]
public class InputButton
{
	public string name;
	public ButtonBehaviorEnum behavior;
}

[System.Serializable]
public class InputAxis
{
	public string name;
	public AxisBehaviorEnum behavior;
	public bool inverted;
}

public enum ButtonBehaviorEnum
{
	aButton,
	bButton,
	xButton,
	yButton,
	lBumper,
	rBumper,
	lTrigger,
	rTrigger,
	lThumbstick,
	rThumbstick,
	selectButton,
	start,
	dpad1,
	dpad2,
	dpad3,
	dpad4
}

public enum AxisBehaviorEnum
{
	moveHorizontal,
	moveVertical,
	lookHorizontal,
	lookVertical,
	miscHorizontal1,
	miscVertical1,
	miscHorizontal2,
	miscVertical2
}