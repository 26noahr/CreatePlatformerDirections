using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InGame : MonoBehaviour
{
    //Get all the objects it might intantiate
    public GameObject row1;
    public GameObject row2;
    public GameObject row3;
    public GameObject row4;
    public GameObject row5;
    public GameObject row6;
    public GameObject coin;
    public Rigidbody2D rb;

    private int maxHeight;
    private int nextHeight;

    public int score;
    public int health;
    
    public GameObject winCanvas;
    public GameObject loseCanvas;

    public AudioSource coinSound;
    public AudioSource lavaSound;
    
    // Start is called before the first frame update
    void Start()
    {
        maxHeight = -4;
        nextHeight = 6;
        score = 0;
        health = 5;
    }

    public int ScorePoint()
    {
        score++;
        coinSound.Play();
        if (score == 20)
        {
            winCanvas.SetActive(true);
            PauseGame();
        }
        return (score);
    }
    public int loseHealth()
    {
        health--;
        lavaSound.Play();
        if (health == 0)
        {
            loseCanvas.SetActive(true);
            PauseGame();
        }
        return (health);
    }

    // Update is called once per frame
    void Update()
    {
        if ((int)rb.position.y > maxHeight)
            maxHeight = (int)rb.position.y;
        if (maxHeight + 8 >= nextHeight) 
        {
            makeRandomRow(nextHeight);
            nextHeight += 2;
        }
    }

    private void makeRandomRow(int height)
    {
        System.Random rnd = new System.Random();
        int rand = rnd.Next(1, 7);
        if (rand == 1)
            Instantiate(row1, new Vector2(0, height), Quaternion.identity, transform);
        if (rand == 2)
            Instantiate(row2, new Vector2(0, height), Quaternion.identity, transform);
        if (rand == 3)
            Instantiate(row3, new Vector2(0, height), Quaternion.identity, transform);
        if (rand == 4)
            Instantiate(row4, new Vector2(0, height), Quaternion.identity, transform);
        if (rand == 5)
            Instantiate(row5, new Vector2(0, height), Quaternion.identity, transform);
        if (rand == 6)
            Instantiate(row6, new Vector2(0, height), Quaternion.identity, transform);
        //place a coin every time
        Instantiate(coin, new Vector2( 7 - (rnd.Next(1,14)), height + 1), Quaternion.identity, transform);
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }
}
