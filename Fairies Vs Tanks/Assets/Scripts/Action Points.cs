using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionPoints : MonoBehaviour
{
    int maxPts = 10;
    public int currentPts = 0;
    Turns turnsScript;

    // Start is called before the first frame update
    void Start()
    {
        turnsScript = FindObjectOfType<Turns>();
    }

    // Update is called once per frame
    void Update()
    {
        //if newTurn = true, currentPts = maxPts. if currentPts = maxPts, set newTurn = false

        if (turnsScript.newTurn == true)
        {
            currentPts = maxPts; 
        }
        else if(currentPts == maxPts)
        {
            turnsScript.NotNewTurn();
        }
    }
}
