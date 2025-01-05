using UnityEngine;

public class PipeSpawnerScript : MonoBehaviour
{
    public GameObject pipePrefab;

    //spawn rate timer
    public float spawnRate = 2;
    private float timer; 

    //randomize height
    private float heightOffset = 6; //vertical offset of pipe +- 6 units. this is the max it can be before pipes are off screen


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        //use Instantiate to create a new game object (pipePrefab) at the position of the pipe spawner
        if (timer < spawnRate)
        {
            //increment the timer by the time it took to complete the last frame universal to all devices
            timer += Time.deltaTime;
        } else {
            spawnPipe();
            timer = 0;
        }
    }


    void spawnPipe() 
    {
        float lowestHeight = 0 - heightOffset;
        float highestHeight = 0 + heightOffset;
        //need to create a new Vector3 whenever we specify our own numbers for a vector
        Instantiate(pipePrefab, new Vector3(transform.position.x, Random.Range(lowestHeight, highestHeight), 0), transform.rotation);
    }
}

