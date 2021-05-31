using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BookAddButton : MonoBehaviour
{
    [SerializeField] private Button _button;
    [SerializeField] private BookIdField _bookIdField;
    private void Awake()
    {
        _button.onClick.AddListener(DrawBookIdField);
    }

    void DrawBookIdField()
    {
        _bookIdField.gameObject.SetActive(true);
    }
}
