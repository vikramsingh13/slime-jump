using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePipeTriggerScript : MonoBehaviour
{
	public GameLogic gameLogic;
	private bool hasTriggered = false;
	
    // Start is called before the first frame update
    void Start()
    {
        gameLogic = GameObject.FindGameObjectWithTag("GameLogic").GetComponent<GameLogic>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (!hasTriggered && collision.gameObject.layer == 3 && !gameLogic.isGameOver){
			gameLogic.AddScore(1);
			hasTriggered = true;
		}
	}
}
