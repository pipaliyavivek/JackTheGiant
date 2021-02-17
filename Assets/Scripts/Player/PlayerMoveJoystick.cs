using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveJoystick : MonoBehaviour
{
    public float speed = 8f, MaxVelocity = 4f;

    [SerializeField]
    private Rigidbody2D myBody;
    private Animator anim;

    private bool moveLeft, moveRight;
    void Awake()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(moveLeft){
            MoveLeft();
        }
        if (moveRight )   {
            MoveRight();
        }

    }

    void MoveLeft()
    {
        float forceX = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);

        if (vel < MaxVelocity)
            forceX = -speed;
        Vector2 temp = transform.localScale;
        temp.x = -1f;
        transform.localScale = temp;
        anim.SetBool("Walk", true);

        myBody.AddForce(new Vector2(forceX, 0));

    }
    public void SetMoveLeft(bool moveLefta)
    {
        this.moveLeft = moveLefta;
        this.moveRight = !moveLefta;
    }
    public void StopMoving()
    {
        moveLeft = moveRight = false;
        moveLeft = false;
        moveRight = false;
        anim.SetBool("Walk", false );

    }
    void MoveRight()
    {
        float forceX = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);

        if (vel < MaxVelocity)
            forceX = speed;
        Vector2 temp = transform.localScale;
        temp.x = 1f;
        transform.localScale = temp;
        anim.SetBool("Walk", true);

        myBody.AddForce(new Vector2(forceX, 0));
    }
}
