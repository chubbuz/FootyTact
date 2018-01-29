using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class tactialMain : NetworkBehaviour {

    public int session;
    private int startTime;
    private Engine engine;
    private GameObject myTeam;
	// Use this for initialization
	void Start () {
        Debug.Log("tactial main script is called");
        startTime = (int)Time.time;
        engine = GetComponent<Engine>();

	}
	
	// Update is called once per frame
	void Update () {
	   if ( (int)Time.time-startTime==session)
        {
            Debug.Log("tactial session ended: Sending data to server");
            

            if (isServer)
            {
                //for server
                myTeam = GameObject.Find("ServerTeam");
                if (myTeam == null) Debug.Log("ServerTeam not found");
                Debug.Log("sending to data to SAME machine");
                if (engine == null) Debug.Log("Engine component not found");
                engine.ServerProposedTactics(myTeam);
            }
            else
            {
                //for client
                myTeam = GameObject.Find("ClientTeam");
                myTeam.GetComponent<NetworkIdentity>().AssignClientAuthority(this.GetComponent<NetworkIdentity>().connectionToClient);
                Debug.Log("sending to data to DIFFERENT machine");
                engine.CmdClientProposedTactics(myTeam);
                //myTeam.GetComponent<NetworkIdentity>().RemoveClientAuthority(this.GetComponent<NetworkIdentity>().connectionToClient);

            }

        }
	}
    
    /*
    [ClientRpc]
    void RpcProposedTactics(string info)
    {
        Debug.Log(info);
    }
    */



}
