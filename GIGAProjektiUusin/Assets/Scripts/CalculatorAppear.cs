using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorAppear : MonoBehaviour
{
    private bool isClicked;

    [SerializeField]
    private Image myImage;
    public GameObject calc;


    void Start()
    {
        myImage.enabled = true;
        calc.SetActive(false);
    }

    // Update is called once per frame
    private void OnMouseDown()
    {

        if (isClicked = !isClicked)
        {
            calc.SetActive(true);
        }
        else
        {
            myImage.enabled = true;
            calc.SetActive(false);
        }
    }
}
