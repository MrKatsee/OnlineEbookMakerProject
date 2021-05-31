using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class BookContainer
{
    readonly List<Book> bookList = new List<Book>();
    const int LIMIT = 4;

    public void AddBook(Book newBook)
    {
        bookList.Add(newBook);
    }

    public void RemoveBook(Book book)
    {
        bookList.Remove(book);
    }
    public List<string> GetBookIdList()
    {
        return bookList.Select(v => v.id).ToList();
    }
    public bool IsTitleOverlapped(string str)
    {
        return bookList.Exists(v => v.id.Equals(str));
    }

    public bool IsStorgaeLimit()
    {
        return  bookList.Count >= LIMIT;
    }
}
