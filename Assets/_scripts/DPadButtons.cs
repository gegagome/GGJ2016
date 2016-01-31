using UnityEngine;
using System.Collections;

//totally got this script from: http://answers.unity3d.com/questions/24785/how-to-use-the-xbox-360-controller-d-pad-pc-.html
//it really pisses me off that I have to use this!
public class DPadButtons : GGJBehaviour {
	private bool up;
	private bool down;
	private bool left;
	private bool right;
	string HorInput = "Horizontal";
	string VerInput = "Vertical";
	float lastDPadX;
	float lastDPadY;
	public DPadButtons() {
		up = down = left = right = false;
		lastDPadX = 0;
		lastDPadY = 0;
	}
	void Update() {
		if(Input.GetAxis (HorInput) == 1 && lastDPadX != 1) { right = true; } else { right = false; }
		if(Input.GetAxis (HorInput) == -1 && lastDPadX != -1) { left = true; } else { left = false; }
		if(Input.GetAxis (VerInput) == 1 && lastDPadY != 1) { up = true; } else { up = false; }
		if(Input.GetAxis (VerInput) == -1 && lastDPadY != -1) { down = true; } else { down = false; }
		lastDPadX = Input.GetAxis(HorInput);
		lastDPadY = Input.GetAxis(VerInput);
		//Debug.Log("UP: " + up);
		//Debug.Log("DOWN: " + down);
		//Debug.Log("LEFT: " + left);
		//Debug.Log("RIGHT: " + right);
		//Debug.Log(Input.GetAxis(HorInput));
	}

	public void SetAxisControls(string horizontalInput, string verticalInput)
	{
		HorInput = horizontalInput;
		VerInput = verticalInput;
	}

	public bool UpPressed()
	{
		return up;
	}
	
	public bool DownPressed()
	{
		return down;
	}
	
	public bool LeftPressed()
	{
		return left;
	}
	
	public bool RightPressed()
	{
		return right;
	}
}