using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;

public class Dialog : MonoBehaviour
{
    public float typingSpeed;
    [SerializeField] private bool PlayerSpeakingFirst;
    public Text robotDialogueText;
    public GameObject robotcontinuebutton;
    [TextArea]
    public string[] robotsentences;
    private int RobotIndex;
    public GameObject panel;
    public GameObject button;
    public GameObject panelhelp;
    public GameObject panelgo;
    public GameObject wholepanel;
    public GameObject button1;
    public GameObject button2;
    public GameObject button3;
    public GameObject image;
    public GameObject drop1;
    public GameObject drop2;
    public GameObject drop3;

    private bool DialogueStarted;
    private void Start()
    {
        Screen.SetResolution(1024, 768, FullScreenMode.ExclusiveFullScreen, 60);

        StartCoroutine(TypeRobot());
    }

    public void showbook()
    {
        wholepanel.SetActive(false);
        image.SetActive(true);
        
    }
    private IEnumerator TypeRobot()
    {
        foreach (char letter in robotsentences[RobotIndex].ToCharArray())
        {
            robotDialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        robotcontinuebutton.SetActive(true);
    }

    

    public void ContýnueRobot()
    {
        //humancontýnueButton.SetActive(false);
        if (RobotIndex < robotsentences.Length -1)
        {
            RobotIndex++;
            
            
            robotDialogueText.text = string.Empty;
            StartCoroutine(TypeRobot());
        }
        else
        {
            panel.SetActive(false);
            panelhelp.SetActive(true);
            /*
            button1.SetActive(true);
            button2.SetActive(true);
            button3.SetActive(true);
            //image.SetActive(true);
            drop1.SetActive(true);
            drop2.SetActive(true);
            drop3.SetActive(true);
            */
            //button.SetActive(true);
        }
        
    }

}
