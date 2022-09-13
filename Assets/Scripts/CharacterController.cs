using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    private Rigidbody characterBody;
    [SerializeField] private float force = 2f;

    private void Start()
    {
        characterBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        characterBody.AddRelativeForce(Vector3.up * force * Time.deltaTime);
    }
}
