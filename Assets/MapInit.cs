using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class MapInit : NetworkBehaviour
{
    public GameObject enemy;

	void Start ()
    {
        Debug.Log("CmdSpawnEnemy");
        CmdSpawnEnemy(new Vector2 (5, 0));
	}
	
	void Update ()
    {
    }

    [Command]
    void CmdSpawnEnemy(Vector3 pos)
    {
        var inst = Instantiate(enemy);
        NetworkServer.Spawn(inst);
    }
}
