using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SAVE : MonoBehaviour
{
    [SerializeField] private GameObject q1;
    [SerializeField] private GameObject q2;
    [SerializeField] private GameObject q3;


    [SerializeField] private GameObject d1;
    [SerializeField] private GameObject d2;
    [SerializeField] private GameObject d3;
    //[SerializeField] private GameObject panel;
    [SerializeField] private GameObject falsefeedback;
    
    [SerializeField] private GameObject correctfeedback;
    
    [SerializeField] private GameObject notebook;
    [SerializeField] private GameObject falsebutton;
    [SerializeField] private GameObject correctbutton;
    [SerializeField] private GameObject nextbutton;
    [SerializeField] private GameObject controlbutton;
    bool checkAnswers()
    {
        var x = false;

        var q_1 = d1.GetComponent<Dropdown>();
        var a_1 = q_1.options[q_1.value].text;
        var q_2 = d2.GetComponent<Dropdown>();
        var a_2 = q_2.options[q_2.value].text;
        var q_3 = d3.GetComponent<Dropdown>();
        var a_3 = q_3.options[q_3.value].text;

        x = (bool)(a_1 == "Katý" && a_2 == "Sývý" && a_3 == "Gaz");

        return q1.GetComponent<Question>().checkAnswers() && q2.GetComponent<Question>().checkAnswers() && q3.GetComponent<Question>().checkAnswers() && x;
    }

    public void metot_kaydet()
    {
        var x = checkAnswers();

        if (x)
        {
            notebook.SetActive(false);
            correctfeedback.SetActive(true);
            

        }
        else
        {
            notebook.SetActive(false);
            falsefeedback.SetActive(true);
       
        }
    }
    public void total()
    {
        falsefeedback.SetActive(false);
        notebook.SetActive(true);
    }
    public void nextpart()
    {
        correctfeedback.SetActive(false);
        nextbutton.SetActive(true);

    }
}

