using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerNetInit : NetworkBehaviour
{
    Transform trCam;

	void Start ()
    {
        if (!isLocalPlayer)
            return;

        // find() works although camera is not active
        trCam = transform.FindChild("Main Camera");
        trCam.gameObject.SetActive(true);

        // set start pos
        transform.position = Util.vector3(transform.position, Util.POS_TYPE.Y, 5);
	}
	
	void Update ()
    {
        if (!isLocalPlayer)
            return;
    }
}
