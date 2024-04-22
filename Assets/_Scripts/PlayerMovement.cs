using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 1f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // FixedUpdate is called once per physics update
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + movement);
    }
}

