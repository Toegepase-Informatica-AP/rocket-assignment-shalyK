using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishingPoint : MonoBehaviour
{
    public GameObject player;
    private Health healthPlayer;
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        healthPlayer = player.GetComponent<Health>();
    }
        private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            healthPlayer.finishReached = true;
            Destroy(gameObject);
        }
    }
}
