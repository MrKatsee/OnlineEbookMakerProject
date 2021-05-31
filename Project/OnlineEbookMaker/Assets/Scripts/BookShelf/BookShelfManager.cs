using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controller
/// </summary>
public class BookShelfManager : MonoBehaviour
{
    public static BookShelfManager Instance { get; private set; }
    private BookIdContainer _container;
    private void Awake()
    {
        SetSingleTon();
        LoadBookList();
    }

    void SetSingleTon()
    {
        if (Instance == null)
            Instance = this;
        else
            Debug.LogError("There must be one singleton object at a time!");
    }

    void LoadBookList()
    {
        _container = new BookIdContainer();
        var idList = BookLoader.LoadBookIdList();
        foreach (var id in idList)
        {
            AddBook(id);
        }
    }
    
    public void AddBook(string id)
    {
        if (StorageChecker.IsStorgaeLimit(_container))
        {
            Viewer.Instance.DrawError();
        }
        else
        {
            Viewer.Instance.DrawBook(id);
            _container.AddBookId(id);
            BookLoader.SaveBookIdList(_container.GetBookIdList());
        }
    }

    public void OnReadBook(string id)
    {
        //todo
    }

    public void OnRemoveBook(string id)
    {
        _container.RemoveBookId(id);
        BookLoader.SaveBookIdList(_container.GetBookIdList());
    }
}
