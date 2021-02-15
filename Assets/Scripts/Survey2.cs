﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Survey2 : MonoBehaviour
{
    public SceneController control;
    public Question currentQuestion;
    public Question[] questions;
    public int[] answers;
    public int currentQuestionInt;
    public Text surveyText;
    public bool surveyComplete;



    // Start is called before the first frame update
    void Start()
    {
        currentQuestion = questions[0];
        loadQuestion();
    }

    public void NextQuestion()
    {
        currentQuestionInt++;

        if (currentQuestionInt < questions.Length)
        {
            surveyComplete = true;
            currentQuestion = questions[currentQuestionInt];
            loadQuestion();
        }
        else
        { 
            control.LaunchVideo2();
            surveyComplete = true;
        }
    }

    void loadQuestion()
    {
        surveyText.text = currentQuestion.surveyQuestion;
    }

    public void buttonPress(int answer)
    {
        answers[currentQuestionInt] = answer;
        NextQuestion();
    }
}
