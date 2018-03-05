using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubMovment : MonoBehaviour
{
    
    public int PlayerNumber = 1;

    [SerializeField]
    public float Speed;
    [SerializeField]
    public float TurnSpeed;
    [SerializeField]
    public float VerticalSpeed;

    private Rigidbody Rigidbody;

    private float MovementInputValue;
    private float TurnInputValue;
    private float VerticalInputValue;

    
    public float StunedSpeed;
    public float StunedTurnSpeed;
    public float StunedVerticalSpeed;

    public bool canMove = true;
    // Use this for initialization
    void Start ()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        

    }

    private void FixedUpdate()
    {
        allowedToMove();

    }

    private void allowedToMove()
    {
        if(canMove == true)
        {
            Move();
            Turn();
            Vertical();
        }

       else if(canMove == false)
        {

        }

    }

    private void Vertical()
    {
        throw new NotImplementedException();
    }

    private void Turn()
    {
        float turn = TurnInputValue * TurnSpeed * Time.deltaTime;

        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

       
        Rigidbody.MoveRotation(Rigidbody.rotation * turnRotation);
    }

    private void Move()
    {
        Vector3 movement = transform.forward * MovementInputValue * Speed * Time.deltaTime;

        Rigidbody.MovePosition(Rigidbody.position + movement);
    }
}
