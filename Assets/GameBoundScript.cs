// using UnityEngine;

// public class GameBoundScript : MonoBehaviour
// {
//     public LogicScript logic;

//     void Start()
//     {
//         logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
//     }

//     private void OnCollisionEnter2D(Collision2D collision) 
//     {
//         // Check if the object that hits the trigger is tagged as Bird
//         // if (collision.gameObject.CompareTag("Bird"))
        
//             Debug.Log("Game over triggered by: " + gameObject.name);
//             logic.gameOver();
        
//     }
// }