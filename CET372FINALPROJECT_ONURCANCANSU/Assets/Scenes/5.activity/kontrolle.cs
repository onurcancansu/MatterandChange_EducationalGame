using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class kontrolle : MonoBehaviour


{
    public GameObject[] wastes;
    public GameObject feedbackpositive;
    public GameObject feedbacknegative;
    public Button kontrol;

    int correctcount = 0;
    int falsecount = 0;
    // Start is called before the first frame update
    public void controlll()
    {
        foreach (GameObject waste in wastes)
        {
            
            if (waste.GetComponent<termo>().iscorrectmatch)
            {
                feedbackpositive.gameObject.SetActive(true);
                correctcount++;
            }
            else
            {
                if (waste.GetComponent<termo>().isinsýde)
                {
                    falsecount++;
                    waste.GetComponent<termo>().backtostart();
                }
            }
        }
        if (correctcount == wastes.Length)
        {
            feedbackpositive.gameObject.SetActive(true);
            
            
        }
        else
        {

            feedbacknegative.gameObject.SetActive(true);
            

        }
    }
}
