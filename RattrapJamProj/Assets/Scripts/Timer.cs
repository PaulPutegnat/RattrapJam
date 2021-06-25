using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool stop = false;

    void Start() {
        startTime = Time.time;
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Time.timeScale = 3;
        }
        if (stop)
            return;
        float t = Time.time - startTime;

        string minutesStr = ((int) t / 60).ToString();
        string secondsStr = ((int)(t % 60)).ToString("00");
        float seconds = (int)(t % 60);

        timerText.text = minutesStr + ":" + secondsStr;
    }

    public void StopTimer()
    {
        stop = true;
    } 
}
