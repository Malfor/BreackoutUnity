using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUiHandler : MonoBehaviour
{
    public TMP_Text scoreTitleText;
    public TMP_InputField inputFieldName;

    // Start is called before the first frame update
    void Start()
    {
        inputFieldName.onValueChanged.AddListener(SetName);
        scoreTitleText.text = "Best Score: " + ScoreManager.Instance.bestName + " : " + ScoreManager.Instance.bestScore;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    private void SetName(string name)
    {
        ScoreManager.Instance.currentName = name;
    }
}
