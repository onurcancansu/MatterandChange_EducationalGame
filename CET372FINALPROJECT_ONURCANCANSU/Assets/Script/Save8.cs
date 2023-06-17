using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Save8 : MonoBehaviour
{
    [SerializeField] private GameObject q1;

    [SerializeField] private GameObject q2;
    [SerializeField] private GameObject q3;
    /*
    [SerializeField] private GameObject q4;
    [SerializeField] private GameObject q5;
    [SerializeField] private GameObject q6;*/


    [SerializeField] private GameObject d1;

    [SerializeField] private GameObject d2;
    [SerializeField] private GameObject d3;
    [SerializeField] private GameObject d4;
    [SerializeField] private GameObject d5;
    [SerializeField] private GameObject d6;
    //[SerializeField] private GameObject panel;
    [SerializeField] private GameObject falsefeedback;
    [SerializeField] private GameObject correctfeedback;
    [SerializeField] private GameObject notebook;
    [SerializeField] private GameObject falsebutton;
    [SerializeField] private GameObject correctbutton;
    [SerializeField] private GameObject nextbutton;

    void Start()
    {
        Screen.SetResolution(1024, 768, FullScreenMode.ExclusiveFullScreen, 60);

    }
    bool checkAnswers()
    {
        var x = false;

        var q_1 = d1.GetComponent<Dropdown>();
        var a_1 = q_1.options[q_1.value].text;

        var q_2 = d2.GetComponent<Dropdown>();
        var a_2 = q_2.options[q_2.value].text;
        var q_3 = d3.GetComponent<Dropdown>();
        var a_3 = q_3.options[q_3.value].text;
        var q_4 = d4.GetComponent<Dropdown>();
        var a_4 = q_4.options[q_4.value].text;
        var q_5 = d5.GetComponent<Dropdown>();
        var a_5 = q_5.options[q_5.value].text;
        var q_6 = d6.GetComponent<Dropdown>();
        var a_6 = q_6.options[q_6.value].text;
        x = (bool)(a_1 == "çorbadan" && a_2 == "suya" && a_3 == "sýcak maddeden" && a_4 == "soðuk maddeye" && a_5 == "büyüktür" && a_6 == "küçüktür");

        return x;
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

