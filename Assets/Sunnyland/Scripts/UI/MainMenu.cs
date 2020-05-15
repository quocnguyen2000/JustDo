﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR 
using UnityEditor.SceneManagement;
#endif
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {
    [SerializeField]
    private GameObject SettingPanel;
    [SerializeField]
    private GameObject MainMenuPanel;
    [SerializeField]
    private GameObject MainLogin;
    [SerializeField]
    private Slider m_slider;


    private void ShowMainMenu() 
    {
        MainMenuPanel.SetActive(true);
        SettingPanel.SetActive(false);
        MainLogin.SetActive(false);
    }
    private void ShowSetting() 
    {
        MainMenuPanel.SetActive(false);
        SettingPanel.SetActive(true);
        MainLogin.SetActive(false);
    }
    private void ShowLogin()
    {
        MainMenuPanel.SetActive(false);
        SettingPanel.SetActive(false);
        MainLogin.SetActive(true);
    }
    
    private void ShowLogin1()
    {
        MainMenuPanel.SetActive(false);
        SettingPanel.SetActive(false);
        MainLogin.SetActive(false);
    }

    // Use this for initialization
    void Start () {
        ShowMainMenu();
        m_slider.value = PlayerPrefs.GetFloat("AudioVolume", 1);
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    //开始按钮
    public void OnStartBtnDown()
    {
        //Application.LoadLevel(1);也行，但是说是过时了
        Application.LoadLevel(1);
    }
    //
    public void OnEndBtnDown() 
    {
        Application.Quit();
    }
    //
    public void OnSliderChanged() 
    {
        PlayerPrefs.SetFloat("Audiovalume", m_slider.value);

    }
    public void OnSettingBtnDown() 
    {
        ShowSetting();
    }
    public void OnLoginBtnDown()
    {
        ShowLogin();
    }

    public void OnBackBtnDown() 
    {
        ShowMainMenu();   
        PlayerPrefs.Save();

    }
}
