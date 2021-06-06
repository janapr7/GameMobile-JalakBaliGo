using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscoreScript : MonoBehaviour
{
    public Text hsText;

    // Start is called before the first frame update
    void Start()
    {
        hsText.text = "HIGHSCORE: " + PlayerPrefs.GetFloat("highscore");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
