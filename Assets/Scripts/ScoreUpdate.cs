using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUpdate : MonoBehaviour
{
    public Text score;
    private int scoreTeller = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            score.text = $"{scoreTeller += 1}";
        }
    }
}
