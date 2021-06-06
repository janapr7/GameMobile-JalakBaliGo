using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerMovement : MonoBehaviour
{
    Rigidbody2D Rb;
    public float jumpForce;
    float score;

    public Text scoreTxt;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = "" + score;

        if(Input.GetMouseButtonDown(0))
        {
            Rb.velocity = Vector2.up * jumpForce;
        }  
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="point")
        {
            score++;
        }
        
        if(collision.gameObject.tag=="pipa")
        {
            Destroy(gameObject);
            if(score>PlayerPrefs.GetFloat("highscore")){
                PlayerPrefs.SetFloat("highscore", score);
            }
            // PlayerPrefs.SetFloat("highscore", score);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }

    // void OnCollisionEnter2D(Collision2D coll) {
    //     // Restart
    //     SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    // }
}
