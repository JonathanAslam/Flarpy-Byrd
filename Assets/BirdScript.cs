using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //to interact with the rigidbody2d component of the bird, create a refernce to it
    //make sure to drag the rigidbody2d component of the bird to this field in the inspector in unity (already done)
    public Rigidbody2D birdRigidbody;

    //create a public float (floating point number) to store the upward velocity of the bird when space bar is pressed.
    //we are able to change this in the inspector in unity instead of having to change back to the script every time
    public float jumpVelocity;

    //create a reference to the LogicScript 
    private LogicScript logic;

    public bool birdIsAlive = true;

    // Start is called ONLY ONCE before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive)
        {
            //if the space bar is pressed, make the bird jump
            birdRigidbody.linearVelocity = Vector2.up * jumpVelocity;
        }
    }

    //if the bird hits something, call the gameOver method from the LogicScript. THIS IS NOT USING TRIGGER, IT IS USING COLLISION since we dont wanna change the score when passing through, but on contact end the game
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if the bird hits a collision object, call the gameOver method from the LogicScript
        logic.gameOver();
        birdIsAlive = false;
    }

}
