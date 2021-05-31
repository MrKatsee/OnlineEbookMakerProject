using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;
public class ErrorUI : MonoBehaviour
{
    private const string playName = "Warning";
    [SerializeField ]private Animation _animation;
    [SerializeField] private TextMeshProUGUI text;
    public void PlayError()
    {
        _animation.Play();
    }

    public void SetMsg(string errorMsg)
    {
        text.text = errorMsg;
    }
}