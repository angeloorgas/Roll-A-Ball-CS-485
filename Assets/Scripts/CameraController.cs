using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour 
{

	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () 
	{
		offset = transform.position - player.transform.position;
	}
	
	// Update is called every frame, exactly when the palyer has moved for the frame.
	void LateUpdate () 
	{
		transform.position = player.transform.position + offset;
	}
}
