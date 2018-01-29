using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class NetworkInfo : NetworkBehaviour {

    private GameObject GameManager;
	// Use this for initialization
	void Start () {
        GameManager= GameObject.Find("GameManager");

        
        spwanner spwan = GameManager.GetComponent<spwanner>();
        if (spwan == null) Debug.Log("Spawn Class not found");
        if (!isServer)
        {
            Debug.Log("This machine is Client");
            spwan.AssignMyTeam("client");

        }
        else
        {
            Debug.Log("This machine is a server");
            spwan.AssignMyTeam("server");
        }

    }
	
}
