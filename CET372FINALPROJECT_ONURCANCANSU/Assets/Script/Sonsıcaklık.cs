using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI
;
public class Sonsıcaklık : MonoBehaviour
{
    [SerializeField] InputField inputField;
    [SerializeField] InputField inputField1;
    
    [SerializeField] Text textDisplay;
    [SerializeField] Text textDisplay1;
    public GameObject result;
    public Button hesapla;
    
    

    public void Substract()
    {
        int num1 = int.Parse(inputField.text);
        int num2 = int.Parse(inputField1.text);
       
        int result = (num1 + num2)/2;
        textDisplay.text = "Karışımın sıcaklığı: " + result;
        if (result != 50)
        {
            hesapla.GetComponent<Button>().interactable = false;
        }
        else
        {
            hesapla.GetComponent<Button>().interactable = true;

        }
        //textDisplay.text = "Aradaki fark: " + result;
    }

    

	
}
