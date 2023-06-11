using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float startTime;

    void Start()
    {
        startTime = Time.time;
    }

    void Update()
    {
        float elapsedTime = Time.time - startTime;
        string timerFormatted = string.Format("Time: {0:0.00}", elapsedTime);
        timerText.text = timerFormatted;
    }
}
