using UnityEngine;
using UnityEngine.UI;

public class CountDownCanva : MonoBehaviour
{
    public CountDown cdref;
    public float timeLeft;
    public Text timeLeftTxt;

    void Start()
    {

        timeLeft = cdref.countdownStart;
        UpdateTimerDisplay();
    }

    void Update()
    {
        if (!cdref.activated)
            return;

        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {

            timeLeft = 0;
            UpdateTimerDisplay();
            cdref.ResetPlayerToSpawn();
            cdref.activated = false;
            timeLeft = cdref.countdownStart;
        }
    }


    public void StartCountdown()
    {
        timeLeft = cdref.countdownStart;
        cdref.activated = true;
        UpdateTimerDisplay();
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeLeft / 60f);
        int seconds = Mathf.FloorToInt(timeLeft % 60f);
        timeLeftTxt.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        Debug.Log(timeLeftTxt.text);
    }
}