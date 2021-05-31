using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class UI_Book : MonoBehaviour {
    [SerializeField] TMP_InputField inputField = default;

    [SerializeField] Button saveBtn = default;
    [SerializeField] Button exitBtn = default;

    [SerializeField] UI_PopUp popUpPrefab = default;

    //변경점이 있는 경우
    private bool isSavable = false;

    private BookData refBook;

    private void Start() {
        refBook = BookManager.Instance.currentBookData;

        inputField.onValueChanged.AddListener((str) => { isSavable = true; refBook.SetData(inputField.text); });

        saveBtn.onClick.AddListener(OnSaveBtnClicked);
        exitBtn.onClick.AddListener(OnExitBtnClicked);

        inputField.text = refBook.textData;
    }

    private void OnSaveBtnClicked() {
        isSavable = false;
        BookManager.Instance.SaveBook();
    }

    private void OnExitBtnClicked() {
        //저장 가능한 변경점이 있는 경우 팝업을 띄워준다
        if (isSavable) {
            UI_PopUp popUp = Instantiate(popUpPrefab, transform);
            popUp.Init(
                title: "Notice", content: "저장 가능한 변경점이 있습니다. 저장하시겠습니까?",
                onYesClicked: () => {
                    OnSaveBtnClicked();
                    ExitToBookshelf();
                },
                onNoClicked: ExitToBookshelf);
        } else {
            ExitToBookshelf();
        }
    }

    private void ExitToBookshelf() {
        SceneManager.LoadSceneAsync("Bookshelf");
    }
}
