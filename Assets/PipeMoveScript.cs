using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
	public float pipeMoveSpeed = 5;
	private float pipeDeadZone = -12.5f;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * pipeMoveSpeed * Time.deltaTime);
		
		if(transform.position.x < pipeDeadZone)
		{
			Debug.Log("Pipe deleted by PipeMoveScript.Update at x : " + transform.position.x);
			Destroy(gameObject);
		}
	}
}
