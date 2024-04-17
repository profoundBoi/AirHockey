using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float time;
    public TextMeshProUGUI num;

    
      void Start()
      {
        time = 5f;


      }

    void Update()
    {
       

        if (time > 0)
           {
              TimeSpan tm = TimeSpan.FromSeconds(time);
             num.text = Mathf.Round(time).ToString();
            time -= Time.deltaTime;

            if(time <= 0)
            {
               Destroy(num);
               SceneManager.LoadScene("SampleScene");
               time = 5;
            }

             Debug.Log("Restart");

           }
            else
            {
               time = 5;
            }

    }
}
