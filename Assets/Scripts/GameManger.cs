using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
{
    public static bool GameIsOver;

    public GameObject GameOverUI;

    public GameObject completeLevelUI;

    void Start()
    {
        GameIsOver = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (GameIsOver)
            return;

        if (Input.GetKeyDown("e"))
        {
            EndGame();
        }

        if(PlayerStats.Lives <= 0)
        {
            

            EndGame();
        }
    }

    void EndGame()
    {
        GameIsOver = true;

        GameOverUI.SetActive(true);
    }

    public void WinLevel()
    {
        GameIsOver = true;
        completeLevelUI.SetActive(true);
    }
}
