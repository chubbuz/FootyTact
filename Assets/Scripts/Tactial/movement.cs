using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {


    private Vector3 screenPoint;
    private Vector3 offset;
    private bool isEnabled;
    private GameObject player;
    private GameObject myTeam;

     void Start()
    {
        Debug.Log("Movement Ready");
        isEnabled = false ;


       // ToEngine engine = new ToEngine();
        
      //  myTeam = GameObject.Find("STeam");
       


        /*
        if (myTeam != null)
        {
            
            Debug.Log("myTeam initialized");
            //engine.recieve(myTeam);
            player = myTeam.transform.Find("Fplayer").gameObject;
            if (player != null)
            {
                Vector3 xPos = player.transform.localPosition;
                float xPosition = xPos.x;
               // float xPosition = xPos.x;
                //float xPosition = xPos.x;


                Debug.Log("child player found and initialized");
            }
            else
            {
                Debug.Log("child player not found");
            }
        }

        else
            Debug.Log("myTeam failed");


    */
    }


    private void Update()
    {
        isEnabled = true;
    }


    void OnMouseDown()
    {

        if (isEnabled == false) return;
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        if (isEnabled == false) return;
        Vector3 cursorPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 cursorPosition = Camera.main.ScreenToWorldPoint(cursorPoint) + offset;
        transform.position = cursorPosition;
    }
}
