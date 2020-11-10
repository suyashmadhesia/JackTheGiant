using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour {

	void OnEnable(){
		Invoke("DestroyCollectabe", 6f);
	}


	void DestroyCollectabe(){
		gameObject.SetActive(false);
	}

}
