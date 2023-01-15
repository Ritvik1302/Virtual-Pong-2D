using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorehigh : MonoBehaviour
{  public Text High2;
   void Start()
   {
    High2.text = PlayerPrefs.GetInt("HighScore").ToString();
   }
  
}
