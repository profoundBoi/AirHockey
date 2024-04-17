using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerMovement : MonoBehaviour
{
    public float moveSpeed;
    float speedX, speedY;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime;
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime;
        rb.velocity = new Vector2(speedX, speedY);
    }
}
