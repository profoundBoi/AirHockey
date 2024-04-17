using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PlayerGoal"))
        {
            GameManager.Instance.UpdateScore(true);
            transform.position = new Vector3(0.170000002f, -1.23000002f, 0);
            
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().angularVelocity = 0;
        }
        if (collision.CompareTag("AiGoal"))
        {
            GameManager.Instance.UpdateScore(false);

            transform.position = new Vector3(0.170000002f, -1.23000002f, 0);

            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<Rigidbody2D>().angularVelocity = 0;

        }
    }
}
