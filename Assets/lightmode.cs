using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class lightmode : MonoBehaviour
{
    public Color32 c1=Color.black;
    public Color32 c2=Color.white;
    public Color32 c3=Color.green;
    public Camera cam;
    public Paddle pp1;
    public Paddle pp2;
    public Ball b1;
    public Text T1;
    public Text T2;
    public Text T3;
    public Text T4;
    public GameObject l;
  
  public void changetolightmode()
   {
        cam.backgroundColor = Color.white;
        pp1.GetComponent<Renderer>().material.color=c1;
        pp2.GetComponent<Renderer>().material.color=c1;
        b1.GetComponent<Renderer>().material.color=c1;
        l.GetComponent<Renderer>().material.color=c1;
        
        T1.color=c1;
        T2.color=c1;
        T3.color=c1;
        T4.color=c1;
   }
  public void changetodarkmode()
   {
        cam.backgroundColor = Color.black;
        pp1.GetComponent<Renderer>().material.color=c3;
        pp2.GetComponent<Renderer>().material.color=c3;
        b1.GetComponent<Renderer>().material.color=c2;
       l.GetComponent<Renderer>().material.color=c2;
        T1.color=c3;
        T2.color=c3;
        T3.color=c3;
        T4.color=c3;
   }
}
