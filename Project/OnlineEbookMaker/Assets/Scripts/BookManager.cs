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

    private BookData currentBookData;

    public void LoadBook(int id) {

    }

    public void SaveBook() {
        
    }
}
