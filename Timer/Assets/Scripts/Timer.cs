using TMPro;
using UnityEngine;
using System.Collections;
using System;

public class Timer : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;

    private int _count = 0;
    private float _delay = 0.5f;
    
    private bool _isRunning = false;

    public void StartTimer()
    {
        _isRunning = !_isRunning;
        StartCoroutine(IncreaseValue());
    }    

    private IEnumerator IncreaseValue()
    {
        WaitForSeconds delay = new(_delay);

        while (_isRunning)
        {
            _count++;

            _text.text = _count.ToString("");

            yield return delay;
        }
    }
}
