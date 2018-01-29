using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MovementController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void activateControls()
    {
        Debug.Log("Activating controls");
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Child Count:" + i);
            this.gameObject.transform.GetChild(i).gameObject.GetComponent<movement>().enabled = true;
            
        }
    }

    public void deactivateControls()
    {
        Debug.Log("Deactivating controls");
        for (int i = 0; i < 5; i++)
            this.gameObject.transform.GetChild(i).gameObject.GetComponent<movement>().enabled = false ;
    }
}
