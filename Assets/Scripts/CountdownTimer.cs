using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;
    [SerializeField] private float startTimeSeconds = 1800f; // 30 minutes
    [SerializeField] private bool startTimerOnPlay = true;

    private float currentTime;
    private bool isRunning = false;

    // Start is called before the first frame update
    private void Start()
    {
        currentTime = startTimeSeconds;
        UpdateTimerDisplay();

        if (startTimerOnPlay)
        {
            StartTimer();
        }
    }

    // Update is called once per frame
    private void Update()
    {
        if (!isRunning) return;

        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;

            if (currentTime < 0)
            {
                currentTime = 0;
            }

            UpdateTimerDisplay();
        }
        else
        {
            isRunning = false;
            Debug.Log("Time is up!");
            // can add some sort of lose condition here
        }
    }

    public void StartTimer()
    {
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public void ResetTimer()
    {
        currentTime = startTimeSeconds;
        UpdateTimerDisplay();
    }

    private void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(currentTime / 60);
        int seconds = Mathf.FloorToInt(currentTime % 60);

        if (timerText != null)
        {
            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}