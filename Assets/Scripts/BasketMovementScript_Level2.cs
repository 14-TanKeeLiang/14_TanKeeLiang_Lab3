using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasketMovementScript_Level2 : MonoBehaviour
{
    public float speed;

    public int score;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      float horizontalInput = Input.GetAxis("Horizontal");

      transform.position = transform.position + new Vector3(horizontalInput * speed * Time.deltaTime, 0, 0);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Healthy"))
        {
            score += 10;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Unhealthy"))
        {
            SceneManager.LoadScene("Lose Scene");
        }
    }
}
