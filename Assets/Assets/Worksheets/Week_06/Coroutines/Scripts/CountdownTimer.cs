using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;

public class CountdownTimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public int seconds = 10;

    void Start()
    {
        StartCoroutine(Countdown());
    }

    IEnumerator Countdown()
    {
        while (seconds > 0)
        {
            timerText.text = seconds.ToString();
            yield return new WaitForSeconds(1f);
            seconds--;
        }
        timerText.text = "GO!";
    }
}

