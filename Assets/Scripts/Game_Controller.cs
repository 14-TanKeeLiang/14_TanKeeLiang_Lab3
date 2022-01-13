using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Controller : MonoBehaviour
{
    public BasketMovementScript basket;

    public Text scoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        basket = GetComponent<BasketMovementScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
