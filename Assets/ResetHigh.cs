using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetHigh : MonoBehaviour
{
   public void resethighscore()
   {
    PlayerPrefs.DeleteKey("HighScore");
   }
}
