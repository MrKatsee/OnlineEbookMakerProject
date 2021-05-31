using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Viewer : MonoBehaviour
{
    public static Viewer Instance { get; private set; }
    [SerializeField] GameObject _bookPrefab;
    [SerializeField] Transform _bookTray;
    [SerializeField] ErrorUI errorUI;

    private void Awake()
    {
        SetSingleTon();
    }
    void SetSingleTon()
    {
        if (Instance == null)
            Instance = this;
        else
            Debug.LogError("There must be one singleton object at a time!");
    }


    public void DrawBook(Book book)
    {
        var bookUI = Instantiate(_bookPrefab, _bookTray).GetComponent<BookUIObject>();
        bookUI.SetBook(book);
    }
    public void DrawError(string errorMsg)
    {
        errorUI.SetMsg(errorMsg);
        errorUI.PlayError();
    }
}