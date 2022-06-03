using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public static float myTime = 0.0f;

    public static bool timeIsRunning = true;

    public Text myTimeText;

    public GameObject canvas;

    private void Awake()
    {
        
    }
    void Start()
    {
        myTime = 0.0f;
        DontDestroyOnLoad(gameObject);
        timeIsRunning = true;
    }
    void Update()
    {

        myTimeText.text = TimeFormat();
        if (SceneManager.GetActiveScene().name == "Game Main Menu")
        {
            Destroy(gameObject);
            canvas.SetActive(false);
        }
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
