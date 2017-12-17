using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 *  @brief 키보드 A,D를 입력받아 Player 좌우 Move
 */
class PlayerMove2D : MonoBehaviour
{
    public int SPEED;
    public int JUMP_POWER;
    private Rigidbody2D rig;
    private Animator anim;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        var dir = input_move();
        act_move(dir);

        var jump = input_jump();
        act_jump(jump);
    }

    int input_move()
    {
        Vector2 horiz = Vector2.zero;

        if (Input.GetKey(KeyCode.A)) // go left
            return 0;
        else if (Input.GetKey(KeyCode.D)) // go right
            return 1;
        else
            return -1;
    }

    void act_move(int dir)
    {
        int LEFT = 0, RIGHT = 1;
        var horiz = Vector2.zero;

        if (dir == LEFT)
        {
            horiz = -transform.right;
            transform.localScale = vector3(transform.localScale, 0, -1);
            anim.SetBool("walk", true);
        }
        else if (dir == RIGHT)
        {
            horiz = transform.right;
            transform.localScale = vector3(transform.localScale, 0, 1);
            anim.SetBool("walk", true);
        }
        else
            anim.SetBool("walk", false);

        transform.Translate(horiz * SPEED * Time.deltaTime, Space.World);
    }

    bool input_jump()
    {
        return Input.GetKeyDown(KeyCode.Space);
    }

    void act_jump(bool jump)
    {
        if (jump)
        {
            Debug.Log("jump");
            rig.AddForce(transform.up * JUMP_POWER);
        }
    }

    Vector3 vector3(Vector3 v, int type, int value)
    {
        const int X = 0, Y = 1, Z = 2;
        var temp = v;

        switch (type)
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
