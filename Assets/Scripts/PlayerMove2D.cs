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

        if (Input.GetKey(KeyCode.A))
            horiz = -transform.right;
        else if (Input.GetKey(KeyCode.D))
            horiz = transform.right;

        transform.Translate(horiz * SPEED * Time.deltaTime, Space.World);
    }
} // class
