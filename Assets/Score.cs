using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public InGame ig;

    // Start is called before the first frame update
    void Start()
    {
        //scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = ("Score: " + ig.score);
    }
}
