using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diyalog1 : MonoBehaviour
{
    public float typingSpeed;
    [SerializeField] private bool PlayerSpeakingFirst;
    public Text robotDialogueText;
    public GameObject robotcontinuebutton;
    [TextArea]
    public string[] robotsentences;
    private int RobotIndex;
    public GameObject panel;
    public GameObject panelhelp;
    //public GameObject button;

    private bool DialogueStarted;
    private void Start()
    {

        StartCoroutine(TypeRobot());
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
        if (RobotIndex < robotsentences.Length - 1)
        {
            RobotIndex++;


            robotDialogueText.text = string.Empty;
            
            StartCoroutine(TypeRobot());
        }
        else
        {
            panel.SetActive(false);
            panelhelp.SetActive(true);
        }
    }
}
