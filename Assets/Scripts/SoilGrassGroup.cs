using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoilGrassGroup : MonoBehaviour
{
    public int CNT;
    public int WIDTH;
    public Transform prefab;

    void Awake()
    {
        for (int i=-CNT;i<=CNT;i+=WIDTH)
        {
            var instance = Instantiate(prefab, new Vector2(i,0), Quaternion.identity, transform);
        }
    }

    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}
}
