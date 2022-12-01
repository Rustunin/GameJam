using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLook : MonoBehaviour
{
    public Transform playerBody;
    public float Sensitivity = 100f;
    private float xRotation=0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        float xMouse = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
        float yMouse = Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

        xRotation -= yMouse;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * xMouse);
        
    }

}
