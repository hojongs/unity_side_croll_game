using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int PUSH_POWER;
    Rigidbody2D rigid;


	void Start ()
    {
        rigid = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        Enemy enemy = col.gameObject.GetComponent<Enemy>();
        Vector2 dir = (col.contacts[0].point.x - transform.position.x) < 0 ?
            new Vector2(-PUSH_POWER/4, PUSH_POWER) : new Vector2(PUSH_POWER/4, PUSH_POWER);

        if (enemy)
        {
            incHealth(enemy.DAMAGE);
            rigid.AddForce(dir);
        }
    }

    void incHealth(int dmg)
    {
        // TODO
    }
}
