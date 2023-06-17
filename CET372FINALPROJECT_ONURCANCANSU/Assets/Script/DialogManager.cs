using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using TMPro;
public class DialogManager : MonoBehaviour
{
    //[TextArea]
    public Text robotDialogueText;
    public Text humanDialogueText;
    public string[] robotsentences;
    public string[] humansentences;
    private int robotindex;
    private int humanindex;
    public float typingSpeed;
    public GameObject robotcontinuebutton;
    public GameObject humancontinuebutton;
    [SerializeField] private bool PlayerSpeakingFirst;
    public GameObject StartButton;
    public string username;
    public GameObject inputField;
    public GameObject textDisplay;
    public GameObject panel;
    public GameObject speechrobot;
    public GameObject speechhuman;
    
    void Start()
    {
        StartDialog();

        


    }

    public void Storename()
    {
        username = inputField.GetComponent<Text>().text;
        textDisplay.GetComponent<Text>().text = "Benim adým " + username ;
        
        panel.SetActive(false);
        humancontinuebutton.SetActive(true);


    }
    /*
    public void Active()
    {
        panel.SetActive(false);
    }*/
    public void Leavename()
    {
        textDisplay.SetActive(false);
    }
    
    public void StartDialog()
    {
        if (PlayerSpeakingFirst)
        {
            StartCoroutine(TypeRobot());

        }
        else
        {
            StartCoroutine(TypeHuman());
        }
    }
        

    IEnumerator TypeRobot()
    {
        foreach(char letter in robotsentences[robotindex].ToCharArray())
        {
            robotDialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
            
        }
        robotcontinuebutton.SetActive(true);
        
    }
    IEnumerator TypeHuman()
    {
        foreach (char letter in humansentences[humanindex].ToCharArray())
        {
            humanDialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        humancontinuebutton.SetActive(true);
    }
   

    public void NextSentenceRobot()
    {
        if (humanindex == 1)
        {
            textDisplay.SetActive(false);
            //humancontinuebutton.SetActive(false);
        }
       
        robotcontinuebutton.SetActive(false);
        if (robotindex < robotsentences.Length - 1)
        {
            robotindex++;
            robotDialogueText.text = string.Empty;
            StartCoroutine(TypeRobot());
            speechhuman.SetActive(false);
            humancontinuebutton.SetActive(false);
            speechrobot.SetActive(true);
           // Debug.Log("player name is:" + playername.text);
            
        }
        else
        {
            robotDialogueText.text = "";
            robotcontinuebutton.SetActive(false);
            humancontinuebutton.SetActive(false);
            StartButton.SetActive(true);
        }
    }
    public void NextSentenceHuman()
    {
        if (humanindex == 0)
        {
            panel.SetActive(true);
            //humancontinuebutton.SetActive(false);
        }
        humancontinuebutton.SetActive(false);
        if (humanindex < humansentences.Length - 1)
        {
            humanindex++;
            humanDialogueText.text = string.Empty;
            StartCoroutine(TypeHuman());
            speechrobot.SetActive(false);
            robotcontinuebutton.SetActive(false);
            speechhuman.SetActive(true);
            
 
        }
        else
        {
            humanDialogueText.text = string.Empty;
            humancontinuebutton.SetActive(false);
            robotcontinuebutton.SetActive(false);
            
        }
        
    }
    
}
