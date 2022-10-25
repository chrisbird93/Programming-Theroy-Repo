using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUIManager : MonoBehaviour
{
    public static MenuUIManager instance;
    [SerializeField]
    Text highScoreText;

    private void Start()
    {
        instance = this;
        UpdateHighScoreMenuText();
    }

    public void StartGame()
    {
        GameManager.instance.StartGame();
    }
    public void QuitGame()
    {
        GameManager.instance.QuitGame();
    }

    public void UpdateHighScoreMenuText()
    {
        highScoreText.text = "High Score: " + GameManager.instance.highScore;
    }
}
