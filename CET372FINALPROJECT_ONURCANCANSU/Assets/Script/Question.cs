using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Question : MonoBehaviour
{
    [SerializeField] private GameObject cb1;
    [SerializeField] private GameObject cb2;
    [SerializeField] private GameObject cb3;

    [SerializeField] private bool kati;
    [SerializeField] private bool sivi;
    [SerializeField] private bool gaz;


    public bool checkAnswers()
    {
        return cb1.GetComponent<Toggle>().isOn == kati && cb2.GetComponent<Toggle>().isOn == sivi && cb3.GetComponent<Toggle>().isOn == gaz;
    }
}


