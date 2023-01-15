using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic back;
    // Start is called before the first frame update
    void Awake()
    {
        if(back==null)
        {
            back= this;
            DontDestroyOnLoad(back);
        }
        else {
            Destroy(gameObject);
        }
    }
}
