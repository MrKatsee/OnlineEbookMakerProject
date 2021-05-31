using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class BookIdContainer
{
    List<string> bookIdList;

    public int Count => bookIdList.Count;
    
    public void AddBookId(string id)
    {
        bookIdList.Add(id);
    }

    public void RemoveBookId(string id)
    {
        bookIdList.Remove(id);
    }
    public List<string> GetBookIdList()
    {
        return new List<string>();
    }
}
