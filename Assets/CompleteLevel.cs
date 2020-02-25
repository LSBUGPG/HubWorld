using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CompleteLevel : MonoBehaviour
{
    Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() => SaveStateAndReturn());
    }

    void SaveStateAndReturn()
    {
        // save level progress
        PlayerPrefs.SetInt(gameObject.scene.name, 1);
        SceneManager.LoadScene("HubWorld");
    }
}
