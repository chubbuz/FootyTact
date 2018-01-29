using UnityEngine;
using System.Collections;

public class ToEngine : MonoBehaviour
{
    public GameObject myTeam;
    public GameObject player;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;


    //Invoked when a button is clicked.
    public void start()
    {
        Debug.Log("Inside the start");

        if (myTeam = GameObject.Find("STeam")){
            Debug.Log("STeam found");
        }
        else
        {
            Debug.Log("STeam not found");
        }
        //Finds and assigns the child of the player named "Gun".
        //gun = player.transform.Find("Gun").gameObject;

        //If the child was found.
        //if (gun != null)
        //{
            //Find the child named "ammo" of the gameobject "magazine" (magazine is a child of "gun").
            //ammo = gun.transform.Find("magazine/ammo");
        //}
        //else Debug.Log("No child with the name 'Gun' attached to the player");
    }

   public void recieve(GameObject team)
    {
        string text = "empty object";
        if (team!=null){
            text = "complete object";
        }
        Debug.Log(text + "is received");
    }
}