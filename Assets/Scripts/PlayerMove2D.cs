using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *  @brief 키보드 A,D를 입력받아 Player 좌우 Move
 */
class PlayerMove2D : MonoBehaviour
{
    public int SPEED = 10;
    private Rigidbody compoRig;

    void Start() { compoRig = GetComponent<Rigidbody>(); }

    void Update()
    {
        Vector2 horiz = Vector2.zero;

        if (Input.GetKey(KeyCode.A)) // go left
        {
            horiz = -transform.right;
            transform.localScale = vector3(transform.localScale, 0, -1);
        }
        else if (Input.GetKey(KeyCode.D)) // go right
        {
            horiz = transform.right;
            transform.localScale = vector3(transform.localScale, 0, 1);
        }

        transform.Translate(horiz * SPEED * Time.deltaTime, Space.World);
    }
    
    Vector3 vector3(Vector3 v, int type, int value)
    {
        const int X = 0, Y = 1, Z = 2;
        var temp = v;

        switch(type)
        {
            case X:
                temp.x = value;
                break;
            case Y:
                temp.y = value;
                break;
            case Z:
                temp.z = value;
                break;
        }

        return temp;
    }
} // class
