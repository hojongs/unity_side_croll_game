using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerEnemyInteract : NetworkBehaviour
{
    public int HORIZ_PUSH;
    public int VERT_PUSH;
    Rigidbody2D rigid;
    bool isHittable;

    void Start()
    {
        if (!isLocalPlayer)
            return;

        rigid = GetComponent<Rigidbody2D>();
        isHittable = true;
    }

    void Update()
    {
        if (!isLocalPlayer)
            return;


    }

    void OnCollisionStay2D(Collision2D col)
    {
        if (!isLocalPlayer)
            return;

        Enemy enemy = col.gameObject.GetComponent<Enemy>();
        Vector2 dir = (col.contacts[0].point.x - transform.position.x) < 0 ?
            new Vector2(-HORIZ_PUSH, VERT_PUSH) : new Vector2(HORIZ_PUSH, VERT_PUSH);

        if (isHittable && enemy)
        {
            incHealth(enemy.DAMAGE);
            //rigid.AddForce(dir);
            rigid.velocity = dir;

            StartCoroutine(avoidAttack(1.0f));
        }
    }

    void incHealth(int dmg)
    {
        // TODO
    }

    IEnumerator avoidAttack(float time)
    {
        isHittable = false;

        yield return new WaitForSeconds(time);

        isHittable = true;
    }
}
