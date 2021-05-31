using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Viewer : MonoBehaviour
{
    public static Viewer Instance { get; private set; }
    [SerializeField] GameObject _bookPrefab;
    [SerializeField] Transform _bookShelfTransform;
    
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


    public void DrawBook(string title)
    {
        var bookUI = Instantiate(_bookPrefab, _bookShelfTransform).GetComponent<BookUIObject>();
        bookUI.SetTitle(title);
    }

    public void DrawWarning(Action callBack)
    {
        
    }

    public void DrawError()
    {
        
    }
}