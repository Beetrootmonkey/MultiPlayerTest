using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class CameraController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (GetComponentInParent<NetworkBehaviour>().isLocalPlayer)
        {
            return;
        }
        GetComponent<Camera>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
