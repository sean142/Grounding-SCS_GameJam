using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private CharacterController coll;
    public float speed;
    public static bool canMove;

    private void Awake()
    {
        coll = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if(canMove)
            MoveMent();
    }

    void MoveMent()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 move = transform.right * horizontalMove + transform.forward * verticalMove;

        coll.Move(move * speed*Time.deltaTime);
    }
}
