using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Page : MonoBehaviour {
    [SerializeField] InputField inputField = default;

    private const int MAX_LINE = 25;

    private void Start() {
        inputField.onValueChanged.AddListener((str) => {  });
    }
}
