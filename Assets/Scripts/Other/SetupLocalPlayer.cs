using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using UnityEngine;

public class SetupLocalPlayer : NetworkBehaviour {

    GameObject otherPlayer;
    // Use this for initialization
    void Start() {

        if (!isServer) Debug.Log("This machine is Client");
        


        
        if (isServer)
        {
            //GetComponent<movement>().enabled = true;
        //    Debug.Log("Local player script enabled");

        }
        else
        {
            
          //  Debug.Log("other player is:" + otherPlayer);


        }
            
        
        

        
            
    }




}
