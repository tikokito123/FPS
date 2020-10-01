﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UImanager : MonoBehaviour
{
    public static UImanager instance;
    public GameObject startMenu;
    public InputField userNameField;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Debug.Log("Instance Already exist, destroying object!");
            Destroy(this);
        }
    }

    public void ConnectedToServer()
    {
        startMenu.SetActive(false);
        userNameField.interactable = false;
        Client.instance.ConnectedToServer();
    }
}
