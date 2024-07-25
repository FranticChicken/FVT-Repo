using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turns : MonoBehaviour
{
    //this will control which player the action scripts will affect as well as the UI text showing whose turn it is
    public bool playerOneTurn = true;

    //this will control the resetting of action points at the beginning of a new turn
    public bool newTurn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ChangePlayerOneTurn()
    {
        if(playerOneTurn == true)
        {
            playerOneTurn = false;
        }
        else if(playerOneTurn == false)
        {
            playerOneTurn = true; 
        }
    }

    public void NewTurn()
    {
        newTurn = true;
    }

    public void NotNewTurn()
    {
        newTurn = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(playerOneTurn);
    }
}
