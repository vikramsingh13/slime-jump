using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameLogic : MonoBehaviour
{
	public int playerScore;
	public Text scoreText;
	public GameObject gameOverScreen;
	public bool isGameOver = false;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	[ContextMenu("Increase Score")]
	public void AddScore(int increment = 1)
	{
		playerScore += increment;
		scoreText.text = playerScore.ToString();
	}
	
	public void RestartGame()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
	
	public void GameOver()
	{
		isGameOver = true;
		gameOverScreen.SetActive(true);
	}
	
	public void CheckOutOfBounds(float y = 0.0f)
	{
		if (y <= -5.26 || y >= 5.26)
		{
			GameOver();
		}
	}
}
