using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class CalculationAppear : MonoBehaviour
{
    private bool isClicked;

    [SerializeField]
    private Image myImage;
    [SerializeField]
    TextMeshProUGUI input;

    public TMP_InputField inputField;
    public GameObject panel;
    string questionText;
    bool isActive = true;

    int playerAnswer;
    int number1;
    int number2;
    bool isCorrect;


    public int quessCount;

    [SerializeField]
    TextMeshProUGUI scoreText;
    int score = 0;



    void Start()
    {
        
        myImage.enabled = true;
        panel.SetActive(false);
        scoreText.text = score.ToString() + " POINTS";
        quessCount = 0;
        
    }

    private void OnMouseDown()
    {

        if (isClicked = !isClicked)
        {
            
            myImage.enabled = false;
            panel.SetActive(isActive);
            Destroy(GetComponent<CircleCollider2D>());

        }

        sumOrMinusQuestion();
        input.text = questionText;
    }


    int sumOrMinusQuestion()
    {
        number1 = Mathf.FloorToInt(Random.value * 50);
        number2 = Mathf.FloorToInt(Random.value * 40);

        int isMinusOrPlus = Mathf.FloorToInt(Random.value * 2);
        //Is it a + or - question
        if (isMinusOrPlus == 0)
        {
            questionText = number1 + "-" + number2 + " = ";
            return (number1 - number2);
        }
        else
        {
            questionText = number1 + "+" + number2 + " = ";
            return (number1 + number2);
        }

    }

    public void PlayerAnswer()
    {
        string answer = inputField.GetComponent<TMP_InputField>().text;
        playerAnswer = int.Parse(answer);



        if (playerAnswer == number1 - number2)
        {
            quessCount++;
            isCorrect = true;
            panel.SetActive(false);
            Debug.Log("Correct");
            AddPoint();

        }
        else if (playerAnswer == number1 + number2)
        {
            quessCount++;
            isCorrect = true;
            panel.SetActive(false);
            Debug.Log("Correct");
            AddPoint();

        }
        else
        {
            quessCount++;
            isCorrect = false;
            inputField.text = "";
            Debug.Log("Wrong");
            AddPoint();

        }
    }

    public void AddPoint()
    {
        if (isCorrect == true && quessCount == 1)
        {
            score = +100;
            scoreText.text = score.ToString() + " POINTS";

        }
        if (isCorrect == true && quessCount >= 2)
        {
            score = +50;
            scoreText.text = score.ToString() + " POINTS";
        }
        if (isCorrect == true && quessCount >= 3)
        {
            score = +20;
            scoreText.text = score.ToString() + " POINTS";
        }
    }


}
