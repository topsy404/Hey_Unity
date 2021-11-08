using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot = default, minutesPivot, secondsPivot;

    const float hoursToDegrees = -30f, minutesToDegrees = -6f, secondsToDegrees = -6f;

    void Awake(){
        DateTime time = DateTime.Now;
        Debug.Log(time.Hour);
        Debug.Log(time.Minute);
        Debug.Log(time.Second);
        Debug.Log(DateTime.Now.TimeOfDay);

        
        hoursPivot.localRotation = Quaternion.Euler(0, 0, hoursToDegrees * time.Hour);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, minutesToDegrees * time.Minute);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, secondsToDegrees * time.Second);


    }


    void Update()
    {

        TimeSpan time = DateTime.Now.TimeOfDay;
        hoursPivot.localRotation = Quaternion.Euler(0f, 0f, hoursToDegrees * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, minutesToDegrees * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, secondsToDegrees * (float)time.TotalSeconds);


    }
}

