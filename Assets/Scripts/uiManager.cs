using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour {

    public Text scoreText;
    public Button replay;

    int score;
    bool gameOver;

	// Use this for initialization
	void Start () 
    {

        gameOver = false;
        score = 0;

        InvokeRepeating("ScoreUpdate", 1.0f, 1.0f);
		
	}
	
	// Update is called once per frame
	void Update () 
    {

        scoreText.text = "Score: " + score;
		
	}

    void ScoreUpdate () 
    {

        if (gameOver == false) {
            score += 1;
        }

    }

    public void ActivateGameOver () 
    {

        gameOver = true;
        replay.gameObject.SetActive(true);

    }

    public void Replay () 
    {

        Application.LoadLevel("Level 1");
        
    }
}
