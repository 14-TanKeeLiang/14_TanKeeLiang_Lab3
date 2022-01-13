using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Controller : MonoBehaviour
{
    public BasketMovementScript basket;

    public Text scoreTxt;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "Score: " + basket.score;

        if(basket.score >= 100)
        {
            SceneManager.LoadScene("GamePlay_Level 2");
        }
    }
}
