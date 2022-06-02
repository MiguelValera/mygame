using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public static float myTime = 0.0f;

    public static bool timeIsRunning = true;

    public Text myTimeText;

    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
    void Update()
    {

        myTimeText.text = TimeFormat();
    }
    public string TimeFormat()
    {
        if (timeIsRunning)
        {
            myTime += Time.deltaTime;
        }

        string min = Mathf.Floor(myTime / 60).ToString("00");
        string sec = Mathf.Floor(myTime % 60).ToString("00");

        return min + ":" + sec;
    }
}
