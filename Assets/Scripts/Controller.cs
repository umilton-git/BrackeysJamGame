using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Camera Camera;
    public CharacterController Player;
    public Collider Body;
    public Collider Ground;
    public float walkSpeed = 3.0f;

    private bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(); 
    }

    void MovePlayer() 
    { 
        if (isGrounded) 
        {
            Vector3 movement = Vector3.zero;

            if (Input.GetKey(KeyCode.A)) movement.x -= 1f;
            if (Input.GetKey(KeyCode.D)) movement.x += 1f;
            if (Input.GetKey(KeyCode.W)) movement.z += 1f;
            if (Input.GetKey(KeyCode.S)) movement.z -= 1f;

            movement = movement.normalized * walkSpeed * Time.deltaTime;
            transform.position += movement;

        }
    }
}
