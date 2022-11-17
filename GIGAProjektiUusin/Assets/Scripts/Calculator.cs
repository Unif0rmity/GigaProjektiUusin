using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI inputField;
    string inputString;
    int[] number = new int[2];
    string operatorSymbol;
    int i = 0;
    int result;
    bool displayResults = false;

    public void ButtonPressed()
    {
        if (displayResults == true)
        {
            inputField.text = "";
            inputString = "";
            displayResults = false;
        }

        Debug.Log(EventSystem.current.currentSelectedGameObject.name);

        string buttonValue = EventSystem.current.currentSelectedGameObject.name;
        inputString += buttonValue;

        int arg;
        if (int.TryParse(buttonValue, out arg))
        {
            if (i > 1) i = 0;

            number[i] = arg;
            i = i + 1;
        }
        else
        {
            switch (buttonValue)
            {
                case "+":
                    operatorSymbol = buttonValue;
                    break;
                case "-":
                    operatorSymbol = buttonValue;
                    break;
                case "*":
                    operatorSymbol = buttonValue;
                    break;
                case "/":
                    operatorSymbol = buttonValue;
                    break;
                case "DEL":
                    ClearInput();
                    break;
                case "=":
                    switch (operatorSymbol)
                    {
                        case "+":
                            result = number[0] + number[1];
                            break;
                        case "-":
                            result = number[0] - number[1];
                            break;
                        case "*":
                            result = number[0] * number[1];
                            break;
                        case "/":
                            result = number[0] / number[1];
                            break;
                    }

                    displayResults = true;
                    inputString = result.ToString();
                    number = new int[2];
                    break;

            }
        }



        inputField.text = inputString;
    }
    public void ClearInput()
    {
        inputField.text = $"0";
        NewCalculation();
    }
    public void NewCalculation()
    {
        displayResults = true;
        number[0] = 0;
        number[1] = 0;
    }
}