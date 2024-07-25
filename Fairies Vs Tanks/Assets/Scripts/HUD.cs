using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUD : MonoBehaviour
{
    Button endTurnButton;
    TextMeshProUGUI playerTurnText;
    TextMeshProUGUI actionPtsText;
    Turns turnsScript;
    ActionPoints actionPointsScript; 

    // Start is called before the first frame update
    void Start()
    {
        endTurnButton = transform.Find("End Turn Button").GetComponent<Button>();
        playerTurnText = transform.Find("Player Turn Text").GetComponent<TextMeshProUGUI>();
        actionPtsText = transform.Find("Action Pts Text").GetComponent<TextMeshProUGUI>();
        turnsScript = FindObjectOfType<Turns>();
        actionPointsScript = FindObjectOfType<ActionPoints>();
        endTurnButton.onClick.AddListener(OnEndButtonClick);
    }

    void OnEndButtonClick()
    {
        turnsScript.ChangePlayerOneTurn();
        turnsScript.NewTurn();
    }

    // Update is called once per frame
    void Update()
    {
        if(turnsScript.playerOneTurn == true)
        {
            playerTurnText.text = "Player 1's turn!";
            playerTurnText.color = Color.red;
            actionPtsText.color = Color.red;
        }
        else if(turnsScript.playerOneTurn == false)
        {
            playerTurnText.text = "Player 2's turn!";
            playerTurnText.color = Color.blue;
            actionPtsText.color = Color.blue;
        }

        actionPtsText.text = "Action Pts" + actionPointsScript.currentPts.ToString();
    }
}
