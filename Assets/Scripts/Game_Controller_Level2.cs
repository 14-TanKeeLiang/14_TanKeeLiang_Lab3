using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Controller_Level2 : MonoBehaviour
{
    public BasketMovementScript_Level2 basket;

    public Text scoreTxt;
    public Text timerText;

    private float secondsCount;
    private int minuteCount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Score: " + basket.score;

        if (basket.score >= 100)
        {
            SceneManager.LoadScene("Win Scene");
        }
        UpdateTimerUI();
    }

    public void UpdateTimerUI()
    {
        //set timer UI
        secondsCount += Time.deltaTime;
        timerText.text = "Timer: " + minuteCount + "m:" + (int)secondsCount + "s";
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
    }
}
