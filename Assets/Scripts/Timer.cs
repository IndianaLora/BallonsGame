using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

     public GameObject CamaraGameOver;
    int countDownStart = 10;
    public Text timerUI;

    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    void countDownTimer(){


        if(countDownStart > 0){
     
       timerUI.text = " " + countDownStart;
       countDownStart--;
       Invoke("countDownTimer", 1.0f);

        }else{

        GameController.Score = GameController.Score - 1;
        countDownStart = 10;
       timerUI.text = " " + countDownStart;
       countDownStart--;
       Invoke("countDownTimer", 1.0f);

       if(GameController.Score == 0)
         CamaraGameOver.SetActive(true);
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
