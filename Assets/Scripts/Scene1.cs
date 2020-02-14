using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

		Debug.Log("Start()");
		NetworkMeshAnimator.Instance.StartAcceptingMessages();

	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log("Update()");
	}
}
