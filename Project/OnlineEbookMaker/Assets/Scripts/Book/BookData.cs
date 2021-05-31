using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookData {
    private string _bookID;
    public string bookID { get { return _bookID; } }

    private string _textData;
    public string textData { get { return _textData; } }

    public void SetData(string data) {
        _textData = data;
    }

    #region Serializer
    public string Serialize() {
        //현재는 data == textData지만, BookData가 담아야 하는 정보가 많아지는 경우를 고려함
        return string.Format("{0}", _textData);
    }
    public void Deserialize(string data) {
        //현재는 data == textData지만, BookData가 담아야 하는 정보가 많아지는 경우를 고려함
        string[] splitedData = data.Split('_');
        _textData = splitedData[0];
    }
    #endregion

    #region Create
    public static BookData Create(string id, string data) {
        BookData newBook = new BookData();
        newBook._bookID = id;
        newBook.Deserialize(data);
        return newBook;
    }
    #endregion
}
