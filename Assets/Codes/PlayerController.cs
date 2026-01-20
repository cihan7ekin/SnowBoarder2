using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rgbd2;
    [SerializeField] float torqueAmount = 1f;

    SurfaceEffector2D surfaceEffector2D;
    [SerializeField] float boostAmount = 50f;
    float normalSpeed = 30f;

    void Start()
    {
        rgbd2 = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindAnyObjectByType<SurfaceEffector2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rgbd2.AddTorque(torqueAmount);
        }   
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rgbd2.AddTorque(-torqueAmount);
        } 

        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = boostAmount;
        }
        else
        {
            surfaceEffector2D.speed = normalSpeed;
        }
    }
}
