using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookManager : MonoBehaviour {
    public static BookManager Instance { get; private set; } = null;

    private void Awake() {
        if (Instance == null) {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    private BookData _currentBookData;
    public BookData currentBookData { get { return _currentBookData; } }

    public void LoadBook(string id) {
        _currentBookData = BookData.Create(id, PlayerPrefs.GetString(id));
    }

    public void SaveBook() {
        PlayerPrefs.SetString(_currentBookData.bookID, _currentBookData.Serialize());
    }
}
