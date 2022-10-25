using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
    This is a multiline comment: 
    4 variable with the player information
     */

    //This variable saves the player's age
    //public int playerAge = 20;
    //private float playerSpeed = 3.125f;
    //public int points = 256;

    public float x = 7;
    public float y = 4;

    //This variable saves the player's username
    //public string playerName = "Silo";

    //public string message = "¡Hola mundo!";
    //[SerializeField]private bool isGameOver = false;

    private void Start()
    {
        /*
        Debug.Log(message);
        Debug.Log(string.Format("Hola {0}, tienes {1} puntos", playerName, points));
        */
        
        Debug.Log(x + y);
        Debug.Log(x - y);
        Debug.Log(x * y);
        Debug.Log(x / y);
        Debug.Log(x % y);
    }
}
