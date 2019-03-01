using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class Cam : MonoBehaviour {

	public List <Transform> players;

	public Vector3 offset;

	private float camSpeed = 1f;
	private float minZoom = 60f;
	private float maxZoom = 20f;
	private Vector3 velocity;
	private Camera camera;

	void Start()
	{
		camera = GetComponent<Camera>();
	}

	void LateUpdate()
	{

		if (players.Count == 0) {
			return;
		}
			
		CameraMovement();
		CameraZoom();
	}

	void CameraMovement()
	{
		Vector3 centre = GetCentre ();
		Vector3 newPosition = centre + offset;

		transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, camSpeed);
	}

	void CameraZoom()
	{
		float zoom = Mathf.Lerp (maxZoom, minZoom, GetDistance() / 80f);
		camera.fieldOfView = Mathf.Lerp (camera.fieldOfView, zoom, Time.deltaTime);
	}

	Vector3 GetCentre()
	{
		if (players.Count == 1) 
		{
			return players[0].position;
		}

		var bounds = new Bounds (players [0].position, Vector3.zero);
		for (int i = 0; i < players.Count; i++) 
		{
			bounds.Encapsulate(players[i].position);
		}
		return bounds.center;
	}

	float GetDistance()
	{
		var bounds = new Bounds (players [0].position, Vector3.zero);
		for (int i = 0; i < players.Count; i++) 
		{
			bounds.Encapsulate(players[i].position);
		}
		return bounds.size.x;
	}
}
