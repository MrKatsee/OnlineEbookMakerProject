using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookManager : MonoBehaviour {
    public static BookManager Instance { get; private set; } = null;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }
    }

    private BookData _currentBookData;
    public BookData currentBookData { get { return _currentBookData; } }

    public void LoadBook(int id) {
        _currentBookData = BookData.Create(id, PlayerPrefs.GetString(id.ToString()));
    }

    public void SaveBook() {
        PlayerPrefs.SetString(_currentBookData.bookID.ToString(), _currentBookData.Serialize());
    }
}
