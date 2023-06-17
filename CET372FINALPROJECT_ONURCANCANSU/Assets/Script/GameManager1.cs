using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager1 : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] InputField inputField1;
    [SerializeField] Text textDisplay;
    [SerializeField] Button defter;

    public void Substract()
    {
        int num1 = int.Parse(inputField.text);
        int num2 = int.Parse(inputField1.text);
        int result = num2 - num1;
        textDisplay.text = "Aradaki fark: " + result;
        if (result !=200)
        {
            defter.GetComponent<Button>().interactable = false;
        }
        else
        {
            defter.GetComponent<Button>().interactable = true;

        }
    }
}
