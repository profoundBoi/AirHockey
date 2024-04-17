using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIScript : MonoBehaviour
{
    public GameObject Puck;
    public float speed;
    

    private float distance; 
     void Start()
    {
        
    }

      void Update()
    {
        distance = Vector2.Distance(transform.position, Puck.transform.position);
        Vector2 direction = Puck.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
    
        if (distance < 10)
        {
            transform.position = Vector2.MoveTowards(this.transform.position, Puck.transform.position, speed * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
        }

       
    }
}
