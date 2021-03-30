using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static int Score = 0;
    public string ScoreString = "Puntos ";



    public Text TextScore;

    public static GameController gameControler;

    private void Awake()
    {
        gameControler = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(TextScore != null)
        {
            TextScore.text = ScoreString + Score.ToString();
        }

        if(Score >= 500){
        SceneManager.LoadScene("Win");
        Score = 0;
        }
    }

}
