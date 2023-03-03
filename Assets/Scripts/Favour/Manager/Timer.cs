using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int maxTime;
    public int minTime;
    public int currentTime;
    public TextMeshProUGUI timerDisplay;

    public UnityEvent TimeOver;

    private void Start()
    {
        currentTime = maxTime;
        StartCoroutine(TimeUpdater());
    }

    public void UpdateTime(int reduceAmount)
    {
        currentTime-= reduceAmount;
        currentTime = Mathf.Clamp(currentTime, minTime, maxTime);
        timerDisplay.text = currentTime.ToString();
    }

    IEnumerator TimeUpdater()
    {
        yield return new WaitForSeconds(1);
        UpdateTime(1);
        if (currentTime > 0)
        {
            StartCoroutine(TimeUpdater());
        }
        else
        {
            TimeOver.Invoke();
        }
    }


}
