using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour {

	[SerializeField]
	private GameObject[] clouds;
	private float distanceBetweenClouds = 3f;

	private float minX;
	private float maxX;
	private float  lastCloudPositionY;

	private float controlX;
	[SerializeField]
	private GameObject[] collectables;

	private GameObject player;

	private void Start() {
		
	}

	private void Update() {
		
	}

}
