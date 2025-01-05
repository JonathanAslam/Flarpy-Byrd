using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    // create move speed variable to control the speed of the pipe moving from right to left across the screen 
    public float moveSpeed;

    //dead zone to remove the pipe after it goes too far off screen. use this to manage memory and avoid over producing pipes in memory
    public float deadZone = -35;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame (use time.delta to access time instead of frame rate to make the game run consistently on different devices)
    void Update()
    {
        //use transform to access the position of the pipe and move it to the left by the moveSpeed variable
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime; 

        if (transform.position.x < deadZone) {
            //destroy the pipe if it goes too far off screen. We can do this since this script is unique to each pipe that is generated, so this destroy command will only destroy the pipe it belongs to
            Destroy(gameObject);
            //let console know pipe has been deleted
            Debug.Log("Pipe deleted");
        }
    }
}
