using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyGameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject mainCanvas;
    public GameObject gameOverCanvas;
    public GameObject finishedCanvas;
    private Health healthPlayer;

    public enum States{Playing, Finishing}
    public States gameState = States.Playing;
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindWithTag("Player");
        }
        healthPlayer = player.GetComponent<Health>();
        finishedCanvas.SetActive(false);
        gameOverCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        switch (gameState)
        {
            case States.Playing:
                if (!healthPlayer.isAlive)
                {
                    gameState = States.Finishing;
                    mainCanvas.SetActive(false);
                    gameOverCanvas.SetActive(true);
                }else if(healthPlayer.finishReached)
                {
                    gameState = States.Finishing;
                    finishedCanvas.SetActive(true);
                    Destroy(player);
                }
                break;
        }
    }

}
