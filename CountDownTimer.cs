using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownTimer : MonoBehaviour
{
    public int countDownTimer;
    public Text countDownDisplayer;
  private void Start()
    {
        StartCoroutine(CountDown());
    }

    private void StartCoroutine(IEnumerable enumerable)
    {
        throw new NotImplementedException();
    }

    IEnumerable CountDown()
    {
        while (countDownTimer > 0)
        {
            countDownDisplayer.text = countDownTimer.ToString();
            yield return new WaitForSeconds(1f);
            countDownTimer--;
        }
        countDownDisplayer.text = "basladi";
        yield return new WaitForSeconds(1f);
        countDownDisplayer.gameObject.SetActive(false);





    }
}
