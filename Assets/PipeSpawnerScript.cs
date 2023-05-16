using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
	public GameObject pipe;
	public float pipeSpawnRate = 2;
	private float pipeSpawnTimer = 0;
	private float pipeHeightOffset = 5;
	
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
		if(pipeSpawnTimer < pipeSpawnRate)
		{
			pipeSpawnTimer += Time.deltaTime;
		} 
		else
		{
			spawnPipe();
			pipeSpawnTimer = 0;
		}
	}
	
	//logic for spawning pipes
	void spawnPipe()
	{
		float low = transform.position.y - pipeHeightOffset;
		float high = transform.position.y + pipeHeightOffset;
		Vector3 pipePosition = new Vector3(transform.position.x, Random.Range(low, high));
		
		Instantiate(pipe, pipePosition, transform.rotation);
	}
}
