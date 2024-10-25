using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public TextMeshProUGUI displayText;

    private string currentInput = "";

    public static bool key = false;

    public GameObject money;
    // void Start()
    // {
    //     money.SetActive(false);
    // }

    public void OnButtonClick(string buttonValue)
    {
        if (buttonValue == "Enter" && currentInput == "7420" )
        {
            money.SetActive(true);
            //UpdateDisplay();
            key = true; 
        }
        else if (buttonValue == "Cancel")
        {
            ClearInput();
        }
        else
        {
            currentInput += buttonValue;
            UpdateDisplay();
        }
    }

    public void ClearInput()
    {
        currentInput = "";
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        displayText.text = currentInput;
    }
}
