using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class BookUIObject : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI titleText;
    [SerializeField] private BookButton _bookButton;
    
    public void SetBook(Book book)
    {
        titleText.text = book.id;
        _bookButton.SetBook(book);
    }
}
