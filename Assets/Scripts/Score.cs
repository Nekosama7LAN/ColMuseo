using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    int counter = 0;

    void Start()
    {
        score.text = counter.ToString();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            counter++;
            score.text = counter.ToString();
        }
    }
}
