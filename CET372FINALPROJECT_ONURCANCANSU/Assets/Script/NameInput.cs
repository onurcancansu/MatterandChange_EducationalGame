using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public string username;
    public GameObject inputField;
    public GameObject textDisplay;

    public void Storename()
    {
        username = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Benim adým " + username + " .";
        
    }
}
