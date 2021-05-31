using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BookUIObject : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    public void SetTitle(string title)
    {
        _text.text = title;
    }
}
