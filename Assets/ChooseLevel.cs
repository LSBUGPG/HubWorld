using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseLevel : MonoBehaviour
{
    Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => SceneManager.LoadScene(name));

        // check for level already done
        int doneLevel = PlayerPrefs.GetInt(name, 0);
        button.interactable = (doneLevel == 0);
    }
}
