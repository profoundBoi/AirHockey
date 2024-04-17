using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportation : MonoBehaviour
{
    [SerializeField] private Transform teleportationPosition;

    private GameObject HockeyPuck;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Puck"))
        {
            Teleport(other.gameObject);
        }
    }

    private void Teleport(GameObject obj)
    {
        obj.transform.position = teleportationPosition.position;
    }
}
