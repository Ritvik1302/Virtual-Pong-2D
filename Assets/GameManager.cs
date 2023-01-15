using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{   
    public Ball ball;
    public Paddle p1paddle;
    public Paddle p2paddle;
    public Text p1;
    public Text High;
    public static int a;
    private int p1score=0;
    // void Start()
    // {
    //    High.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    // }
    public void player1scores()
    {
        p1score++;
        p1.text=p1score.ToString();
    }
    public void player2scores()
    {  
        if(p1score>PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore",p1score);
            High.text =  PlayerPrefs.GetInt("HighScore").ToString();
        }
        p1score=0;
        p1.text="0".ToString();
        p1paddle.ResetPosition();
        p2paddle.ResetPosition();
        ball.reset();
        ball.AddStartingForce();
        SceneManager.LoadScene("Restart"); 
    }
    void FixedUpdate ()
    {
        if(Input.GetKey("space"))
        {
            SceneManager.LoadScene("Menu");
        }
    }
}
