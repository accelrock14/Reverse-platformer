using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    public float gravityScale = 10f;
    float angle = 0f;

    Vector2 gravityDirection = new(0f, -1f);

    private Rigidbody2D rb;
    private Camera mainCamera;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mainCamera = Camera.main;
    }

    void Update()
    {
        // Check arrow key inputs
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0f)
        {
            gravityDirection = new Vector2(horizontalInput, verticalInput).normalized;
            angle = 90f * gravityDirection.x;
        }
        else if (verticalInput != 0f)
        {
            gravityDirection = new Vector2(horizontalInput, verticalInput).normalized;
            angle = gravityDirection.y < 0 ? 0f : 180f;
        }

        // Apply the force to the object
        rb.AddForce(gravityDirection * gravityScale);

        Quaternion targetRotation = Quaternion.Euler(0f, 0f, angle);

        mainCamera.transform.rotation = Quaternion.Lerp(mainCamera.transform.rotation, targetRotation, 0.1f);
    }
}
