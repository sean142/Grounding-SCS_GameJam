using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f;

    public Transform playerBody;

    float xRotation = 0f;
    float yRotation = 0f;

    public static bool canMoveScreen;

    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if (canMoveScreen)
        {
            float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
            float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -20f, 20f);

            yRotation += mouseX;
            yRotation = Mathf.Clamp(yRotation, -30f, 30f);

            transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
            playerBody.localRotation = Quaternion.Euler(0f, yRotation, 0f);
        }    
    }
}
