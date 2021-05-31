using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Controller
/// </summary>
public class BookShelfManager : MonoBehaviour
{
    public static BookShelfManager Instance { get; private set; }
    private BookContainer _container;
    const string error_bookShelf = "Warning : Bookshelf is full!!";
    private const string error_titleOverlapped = "Warning : Title should not be overlapped";
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
        _container = new BookContainer();
        var idList = BookLoader.LoadBookIdList();
        foreach (var id in idList)
        {
            if(!id.Equals(String.Empty))
                AddBook(id);
        }
    }

    #region  Acitons
    public void AddBook(string id)
    {
        if (_container.IsTitleOverlapped(id))
        {
            Viewer.Instance.DrawError(error_titleOverlapped);
        }
        else if (_container.IsStorgaeLimit())
        {
            Viewer.Instance.DrawError(error_bookShelf);
        }
        else
        {
            Book newBook = new Book(id);
            Viewer.Instance.DrawBook(newBook);
            _container.AddBook(newBook);
            BookLoader.SaveBookIdList(_container.GetBookIdList());
        }
    }

    public void OpenBook(Book book)
    {
        BookManager.Instance.LoadBook(book.id);
        SceneManager.LoadSceneAsync("Book");
    }

    public void RemoveBook(Book book)
    {
        _container.RemoveBook(book);
        BookLoader.SaveBookIdList(_container.GetBookIdList());
    }

    #endregion
 
}
