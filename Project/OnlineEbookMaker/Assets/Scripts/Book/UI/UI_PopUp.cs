using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UI_PopUp : MonoBehaviour {
    [SerializeField] Text titleText = default;
    [SerializeField] Text contentText = default;

    [SerializeField] Button yesBtn = default;
    [SerializeField] Button noBtn = default;

    public void Init(string title, string content, UnityAction onYesClicked, UnityAction onNoClicked) {
        titleText.text = title;
        contentText.text = content;

        yesBtn.onClick.AddListener(onYesClicked);
        noBtn.onClick.AddListener(onNoClicked);
    }
}
