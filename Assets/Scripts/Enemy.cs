using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Enemy : NetworkBehaviour
{
    public int DAMAGE = 1;

	void Start ()
    {
        Debug.Log("Enemy Spawned");
	}
	
	void Update ()
    {
    }
}
