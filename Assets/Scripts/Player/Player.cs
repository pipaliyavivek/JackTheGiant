using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 8f, MaxVelocity = 4f;

    [SerializeField]
    private Rigidbody2D myBody;
    private Animator anim;
    
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }
    private void FixedUpdate()
    {
        playermove();
    }
    void Update()
    {
        
    }
    void playermove()
    {
        float forceX = 0f;
        float vel = Mathf.Abs(myBody.velocity.x);

        float h = Input.GetAxisRaw("Horizontal");

        if (h > 0)
        {

            if (vel < MaxVelocity)
                forceX = speed;
            Vector2 temp = transform.localScale;
            temp.x = 1.3f;
            transform.localScale = temp;
            anim.SetBool("Walk",true);
        }
        else if (h < 0)
        {
            if (vel < MaxVelocity)
                forceX = -speed;
            Vector2 temp = transform.localScale;
            temp.x = -1.3f;
            transform.localScale = temp;
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false );

        }

        myBody.AddForce(new Vector2(forceX, 0));

        }
    }


