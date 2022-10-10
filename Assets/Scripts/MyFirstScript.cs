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
    public int playerAge = 20;
    private float playerSpeed = 3.125f;

    //This variable saves the player's username
    public string playerName = "Silo";
    [SerializeField]private bool isGameOver = false;
}
