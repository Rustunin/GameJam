using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerControll : MonoBehaviour
{
    private CharacterController controller;
    private bool groundedPlayer;
    public float groundDistance;
    public LayerMask groundMask;
    [SerializeField]public static float playerSpeed = 8.0f;
    public static float jumpHeight = 8.0f;
    private float gravityValue = -9.81f;
    public Transform groundCheck;
    Vector3 velocity;

    private void Start()
    {
        controller=GetComponent<CharacterController>();

    }

    void Update()
    {
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            velocity.y += Mathf.Sqrt(jumpHeight * -2.0f * gravityValue);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            playerSpeed *= 2;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            playerSpeed = 8f;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            
        }

        groundedPlayer = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (groundedPlayer && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * y;
        controller.Move(move * playerSpeed * Time.deltaTime);


        // Changes the height position of the player..
      

        velocity.y += gravityValue * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
      
    }
}
