using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookData {
    private int bookID;
    private string textData;

    public BookData(string data) {
        string[] splitedData = data.Split('_');
        bookID = Convert.ToInt32(splitedData[0]);
        textData = splitedData[1];
    }

    public string Serialize() {
        return string.Empty;
    }
}
