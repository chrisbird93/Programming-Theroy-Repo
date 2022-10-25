using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIHandler : MonoBehaviour
{
    public static UIHandler instance { get; private set; }

    [SerializeField]
    Text scoreText;
    [SerializeField]
    Text winText;
    [SerializeField]
    Text gameOverText;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public void UpdateScoreText()
    {
        scoreText.text = "POINTS: " + GameManager.instance.playerPoints;
    }

    public void WinTextActive()
    {
        winText.gameObject.SetActive(true);
    }
    public void GameOverTextActive()
    {
        gameOverText.gameObject.SetActive(true);
    }
}
