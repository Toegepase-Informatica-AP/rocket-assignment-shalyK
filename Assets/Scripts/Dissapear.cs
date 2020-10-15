using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dissapear : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);   
        }
    }
}
