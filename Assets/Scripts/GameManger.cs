using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    private bool gameEnded = false;
    // Update is called once per frame
    void Update()
    {
        if(PlayerStats.Lives <= 0)
        {
            if (gameEnded)
                return;

            EndGame();
        }
    }

    void EndGame()
    {
        Debug.Log("Game Over!");
        gameEnded = true;
    }
}
