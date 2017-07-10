using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float speed ;
	public float xMin, xMax ;
	public float tilt;
	
	// joint position at the moment, in Kinect coordinates
	public Vector3 handLeftPosition;
	public Vector3 handRightPosition;
	public float rightOrLeft;
	public float basketSpeed = 0.25f;
	public float changeMargin = 0.1f;

	void Awake () 
	{	
		rightOrLeft = 0;
		speed = PlayerPrefs.GetFloat(MenuPlayerPrefs.basketSpeedInput);
		transform.localScale = new Vector3(PlayerPrefs.GetFloat(MenuPlayerPrefs.basketSizeInput), 2.0f, 2.0f);
	}

	void Update () {
		float x = Input.GetAxis ("Horizontal");
		//float y = Input.GetAxis ("Vertical");

		if(FruitPickerPausePose.isPaused || FruitPickerPausePose.isFinished){
			x = 0.0f;
		}

		//Vector3 movement = new Vector3 ( (basketSpeed)*rightOrLeft , 0.0f, 0.0f); //Kinect için kontroller
		Vector3 movement = new Vector3 ( x , 0.0f, 0.0f); // Klavye için kontroller

		rigidbody.velocity = movement * speed;
		rigidbody.position = new Vector3 ( Mathf.Clamp(rigidbody.position.x, xMin, xMax), 0.0f, 0.0f);
	}

}
