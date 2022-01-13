using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasketMovementScript : MonoBehaviour
{
    public float speed;

    public int score;

    private AudioSource audioSource;
    public AudioClip[] audioClip;
   
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
            audioSource.PlayOneShot(audioClip[0]);
            score += 10;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("Unhealthy"))
        {
            audioSource.PlayOneShot(audioClip[1]);
            SceneManager.LoadScene("Lose Scene");
        }
    }
}
