using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Diyalog6 : MonoBehaviour
{
    public float typingSpeed;
    [SerializeField] private bool PlayerSpeakingFirst;
    public Text DialogueText;
    public GameObject continuebutton;
    [TextArea]
    public string[] sentences;
    private int Index;
    public GameObject panel;
    public GameObject info;
    


    private bool DialogueStarted;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(TypeRobot());

    }
    private IEnumerator TypeRobot()
    {
        foreach (char letter in sentences[Index].ToCharArray())
        {
            DialogueText.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        continuebutton.SetActive(true);
    }

    public void ContýnueRobot()
    {
        //humancontýnueButton.SetActive(false);
        if (Index < sentences.Length - 1)
        {
            Index++;


            DialogueText.text = string.Empty;
            StartCoroutine(TypeRobot());
        }
        else
        {
            panel.SetActive(false);
            info.SetActive(true);
           
        }

    }
}
