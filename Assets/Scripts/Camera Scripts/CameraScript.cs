using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private float speed = 1f;
    private float acceleration = 0.2f;
    private float maxSpeed = 3.2f;

    private float easySpeed = 3.4f;
    private float mediumSpeed = 3.8f;
    private float hardSpeed = 4.2f;

    [HideInInspector ]
    public bool moveCamera; 

    void Start()
    {
        if(GamePrefences.GetEasyDifficultyState() == 1 )
        {
            maxSpeed = easySpeed;
        }
        if (GamePrefences.GetMediumDifficultyState () == 1)
        {
            maxSpeed = mediumSpeed;          
        }
        if (GamePrefences.GetHardDifficultyState () == 1)
        {
            maxSpeed = hardSpeed;
        }

        moveCamera = true;
    }

    void Update()
    {
        if(moveCamera)
        {
            MoveCamera();
        }
    }
    void MoveCamera()
    {
        Vector3 temp = transform.position;
        float oldy = temp.y;
        float newy = temp.y - (speed * Time.deltaTime);

        temp.y = Mathf.Clamp(temp.y, oldy, newy);

        transform.position = temp;

        speed += acceleration * Time.deltaTime;

        if (speed > maxSpeed)
            speed = maxSpeed;
    }
}
