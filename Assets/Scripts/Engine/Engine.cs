using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Engine : NetworkBehaviour {

	// Use this for initialization
    private GameObject serverTeam;
    private GameObject clientTeam;
      
	void Start () {
        Debug.Log("Soccer Engine started");
		//initialize two teams
	}
	    
	// Update is called once per frame
	void Update () {
		
	}

    public void ServerProposedTactics(GameObject team)
    {
        //update serverTeam
        Debug.Log("updating server team");
        serverTeam = team;
    }

    [ClientRpc]
    public void RpcClientProposedTactics(GameObject team)
    {
        //update clientTeam
        Debug.Log("updating Client team");
        clientTeam = team;
    }

    [Command]
    public void CmdClientProposedTactics(GameObject team)
    {
        //update clientTeam
        Debug.Log("updating Client team");
        clientTeam = team;
    }


}
