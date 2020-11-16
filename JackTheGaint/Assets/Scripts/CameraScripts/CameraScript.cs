using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	private float speed = 1f;
	private float accelerate = 0.2f;
	private float maxSpeed = 3.2f;

	private float easySpeed = 3.4f;
	private float mediumSpeed = 4.2f;
	private float hardSpeed = 5.0f;

	[HideInInspector]
	public bool moveCamera;
	void Start () {

		if(GamePrefrences.GetEasyDifficulty() == 1){
			maxSpeed = easySpeed;
			print("easyCameraSpeed");
		}

		if(GamePrefrences.GetMediumDifficulty() == 1){
			maxSpeed = mediumSpeed;
			print("MediumCameraSpeed");
		}

		if(GamePrefrences.GetHardDifficulty() == 1){
			maxSpeed = hardSpeed;
			print("hardCmeraSpeed");
		}

		moveCamera = true;
	}


	void Update () {
		if(moveCamera){
			MoveCamera();
		}
	}

	void MoveCamera(){
		Vector3 temp = transform.position;
		float oldY = temp.y;
		float newY = temp.y - (speed * Time.deltaTime);

		temp.y = Mathf.Clamp (temp.y, oldY, newY);

		transform.position = temp;

		speed += accelerate * Time.deltaTime;

		if(speed > maxSpeed){
			speed = maxSpeed;
		}
	}
}
