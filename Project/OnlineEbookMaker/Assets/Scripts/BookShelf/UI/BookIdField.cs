using System;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;
public class BookIdField : MonoBehaviour
{
    [SerializeField] private Button _yesButton;
    [SerializeField] private Button _noButton;
    [SerializeField] private TMP_InputField _inputField;

    private void Awake()
    {
        _yesButton.onClick.AddListener(AddBook);
        _noButton.onClick.AddListener(Close);
    }

    void AddBook()
    {
        BookShelfManager.Instance.AddBook(_inputField.text);
        Close();
    }

    void Close()
    {
        _inputField.text = "";
        gameObject.SetActive(false);
    }
}