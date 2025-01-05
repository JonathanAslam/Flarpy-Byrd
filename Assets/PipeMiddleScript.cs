using UnityEngine;

public class PipeMiddleScript : MonoBehaviour
{
    public LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        //create tag called Logic in unity. it is at the top of the inspector where it says tag. make sure to assign Logic tag to the Logic Manager game object
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //will run whenever an object hits the trigger. Make sure to check the box in the inspector to make the object a trigger --> 'Is Trigger'
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        //if the object that hits the trigger is tagged as Bird, then add a point to the score 
        // if (collision.gameObject.layer == 3) { //the layer for the bird is 3 
        if (collision.gameObject.layer == 3) 
        {
            logic.addScore(1);
        }
    }
}