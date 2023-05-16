using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeScript : MonoBehaviour
{
	public Rigidbody2D slimeRigidbody;
	private float jumpPower = 7;
	public GameLogic gameLogic;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Space) && !gameLogic.isGameOver)
		{
			slimeRigidbody.velocity = Vector2.up * jumpPower;
		}
		
		gameLogic.CheckOutOfBounds(transform.position.y);
    }
	
	private void OnCollisionEnter2D(Collision2D collision)
	{
		gameLogic.GameOver();
	}
}
