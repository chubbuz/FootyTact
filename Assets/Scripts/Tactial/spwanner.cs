using UnityEngine;

public class spwanner : MonoBehaviour
{
    public GameObject ServerTeam;                // The enemy prefab to be spawned.
    public GameObject ClientTeam;                // The enemy prefab to be spawned.
    private GameObject MyTeam;
    public GameObject ServerTeamPrefab;                // The enemy prefab to be spawned.
    public GameObject ServerSpawnPoints;         // An array of the spawn points this enemy can spawn from.

    public GameObject ClientTeamPrefab;                // The enemy prefab to be spawned.
    public GameObject ClientSpawnPoints;         // An array of the spawn points this enemy can spawn from.

    public float spawnTime = 1f;            // How long between each spawn.
    private int spawnPointIndex;


    void Start()
    {

       

        Debug.Log("Team Tag added");

       // Spawn();


    }


    void Spawn()
    {
        //GameObject server = GameObject.Find("ServerTeamPrefabPrefab");
        // Create an instance of the player
        //GameObject ServerTeam;// = GameObject.Find("ServerTeam");
        //GameObject ClientTeam;// = GameObject.Find("ClientTeam");




        Debug.Log("Trying to Spawn");
        for (spawnPointIndex = 0; spawnPointIndex < 5; spawnPointIndex++)
        {
            GameObject serverPlayer = ServerTeamPrefab.gameObject.transform.GetChild(spawnPointIndex).gameObject;
            Transform serverSpawnPoint = ServerSpawnPoints.gameObject.transform.GetChild(spawnPointIndex);
            serverPlayer=Instantiate(serverPlayer, serverSpawnPoint.position, serverSpawnPoint.rotation);
            serverPlayer.transform.parent = ServerTeam.transform;

            GameObject clientPlayer = ClientTeamPrefab.gameObject.transform.GetChild(spawnPointIndex).gameObject;
            Transform clientSpawnPoint = ClientSpawnPoints.gameObject.transform.GetChild(spawnPointIndex);
            clientPlayer=Instantiate(clientPlayer, clientSpawnPoint.position, clientSpawnPoint.rotation);
            clientPlayer.transform.parent = ClientTeam.transform;

            
            
        }

        Debug.Log("All player Spawned");
    }

    public void AssignMyTeam(string team){
        ServerTeam = Instantiate(ServerTeam);//, Vector3.zero, Quaternion.identity);
        ServerTeam.gameObject.tag = "ServerTeam";
        ClientTeam = Instantiate(ClientTeam);//, Vector3.zero, Quaternion.identity);
        ClientTeam.gameObject.tag = "ClientTeam";


        
        Spawn();

        if (team == "server")
        {
            MyTeam = GameObject.FindGameObjectWithTag("ServerTeam");
            if (MyTeam == null) Debug.Log("Server team not found");
            MovementController controller = MyTeam.GetComponent<MovementController>();
            Debug.Log("Total childs of MyTeam="+MyTeam.transform.childCount );
            controller.activateControls();
            Debug.Log("This is server");
            GameObject.FindGameObjectWithTag("ClientTeam").GetComponent<MovementController>().deactivateControls();

        }
        else
        {
            MyTeam = GameObject.FindGameObjectWithTag("ClientTeam");
            Debug.Log("This is client");
            MovementController controller = MyTeam.GetComponent<MovementController>();
            GameObject.FindGameObjectWithTag("ServerTeam").GetComponent<MovementController>().deactivateControls();
        }

        
        

       

    }
}