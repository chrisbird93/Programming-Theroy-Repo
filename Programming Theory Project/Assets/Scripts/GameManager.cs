using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }

    public int playerPoints = 0;
    public int highScore;
    public bool gameOver;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        LoadHighScore();
        if (MenuUIManager.instance != null)
        {
            MenuUIManager.instance.UpdateHighScoreMenuText();
        }
    }

    private void Update()
    {
        if(gameOver)
        {
            if(Input.GetKeyDown(KeyCode.Space))
            {
                StartGame();
            }
            else if(Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene(0);
            }
        }
    }

    public void GameOver()
    {
        if (gameOver == false)
        {
            gameOver = true;
            Debug.Log("You lose!");
            UIHandler.instance.GameOverTextActive();
        }
    }
    public void GameWin()
    {
        // Game win
        if (gameOver == false)
        {
            gameOver = true;
            Debug.Log("You win! Total points: " + playerPoints);
            UIHandler.instance.WinTextActive();

            if (CheckIfHighScore())
            {
                SaveNewHighscore();
            }
        }
    }

    public void AddPoints(int pointsToAdd)
    {
        if (gameOver == false)
        {
            playerPoints += pointsToAdd;
            UIHandler.instance.UpdateScoreText();
            Debug.Log("Given points!");
        }
    }

    public void QuitGame()
    {

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); // original code to quit Unity player
#endif
    }


    public void StartGame()
    {
        SceneManager.LoadScene(1);
        playerPoints = 0;
        gameOver = false;
    }

    public void LoadMainMenu()
    {
        ResetGame();
        SceneManager.LoadScene(0);
    }

    void ResetGame()
    {
        playerPoints = 0;
        gameOver = false;
        UIHandler.instance.UpdateScoreText();
    }

    bool CheckIfHighScore()
    {
        if (playerPoints > highScore)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    class SaveData
    {
        public int highScore;
    }

    void SaveNewHighscore()
    {
        highScore = playerPoints;

        SaveData save = new SaveData();
        save.highScore = highScore;

        string json = JsonUtility.ToJson(save);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    void LoadHighScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData save = JsonUtility.FromJson<SaveData>(json);

            highScore = save.highScore;
        }
    }
}
