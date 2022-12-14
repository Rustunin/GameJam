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
    private Animator animator;

    public Transform spawnPoint;
    public GameObject swordImage;
    Vector3 zeronull;
    public AudioSource footsound;
    private void Start()
    {
        zeronull = Vector3.zero;
        animator = GetComponent<Animator>();
        controller=GetComponent<CharacterController>();

    }

    
//         if(!footsound.isPlaying)
//         {
//             footsound.Play();
//             footsound.loop = true;
//         }
//     }


//     else
//{
//    footsound.Stop();

//}
void Update()
    {
        if (menu2.isRestart)
        {
            controller.enabled = false;
            gameObject.transform.position = spawnPoint.position;
            controller.enabled = true;  
            menu2.isRestart = false;
            swordImage.SetActive(true);           
        }
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

        groundedPlayer = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (groundedPlayer && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * y;
        float Ismoving = Vector3.ClampMagnitude(move, 1).magnitude;
        controller.Move(move * playerSpeed * Time.deltaTime);
          if (Ismoving>=0.1f)
          {
             if (!footsound.isPlaying)
             {
                footsound.Play();
                footsound.loop = true;
             }
        }
        else
        {
            footsound.Stop();
        }
        if (attackEnemy.animWalkcount==0)
        {
            animator.SetFloat("speed", Vector3.ClampMagnitude(move, 1).magnitude);
        }
        else if (attackEnemy.animWalkcount == 1)
        {
            animator.SetFloat("speed", Vector3.ClampMagnitude(zeronull,1).magnitude);
        }
      


        // Changes the height position of the player..
      

        velocity.y += gravityValue * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
      
    }
}
