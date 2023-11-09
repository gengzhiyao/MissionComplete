using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class ReserveData : MonoBehaviour
{
    public string userName;
    public TMP_InputField inputName;
    public static ReserveData singleton;
    void Awake()
    {
        if (singleton==null)
        {
            singleton = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        
        DontDestroyOnLoad(gameObject);
    }
    void Start()
    {
        inputName.onEndEdit.AddListener(GetUserName);
    }
    
    void Update()
    {
        
    }

    public void GetUserName(string name)
    {
        userName = name; 
    }

    public void ClickStartButton()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
        Application.Quit();
        #endif
    }
}
