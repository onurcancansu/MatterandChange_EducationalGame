using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class control : MonoBehaviour
{
    public GameObject[] wastes;
    public GameObject feedbackpositive;
    public GameObject feedbacknegative;
    public GameObject object1;
    public GameObject object2;
    public GameObject object3;
    //public GameObject instructýon;
    public Button Next;
    public Button kontrol;
    
    //public Text t1;
    //public Text t2;
    //public GameObject gameover;
    int correctcount = 0;
    int falsecount = 0;

    void Start()
    {
        //StartCoroutine(Sonraac());
        //feedback.SetActive(false);
        //kontrol.GetComponent<Button>().interactable = false;
                   
    }
    
    public void controlet()
    {
        //Debug.Log("okey");
        //Debug.Log("mathcing : " + wastes[0].GetComponent<Drag>().iscorrectmatch);
        
        foreach(GameObject waste in wastes)
        {
            //Debug.Log("matching foreach :" + waste.GetComponent<Drop>().iscorrectmatch);
            if (waste.GetComponent<Drop>().iscorrectmatch)
            {
                correctcount++;
                
            }
            else
            {
                if (waste.GetComponent<Drop>().isinsýde)
                {
                    falsecount++;
                    waste.GetComponent<Drop>().backtostart();
                    correctcount = 0;
                    
                }
            }
        }
        //string message ="";
        if (correctcount == wastes.Length)
        {
            Debug.Log("doðru sayýsý" + correctcount);
            feedbackpositive.gameObject.SetActive(true);
            kontrol.GetComponent<Button>().interactable = false;
            object1.GetComponent<Button>().interactable = false;
            object2.GetComponent<Button>().interactable = false;
            object3.GetComponent<Button>().interactable = false;
            //message=" Süper! Tamamýný doðru yaptýn! 6 adet atýðý türlerine göre ayýrýp, doðru çöp kutularýna yerleþtirebildin ";



        }
        else
        {
            Debug.Log("doðru sayýsý" + correctcount);

            feedbacknegative.gameObject.SetActive(true);
            kontrol.GetComponent<Button>().interactable = false;
            object1.GetComponent<Button>().interactable = false;
            object2.GetComponent<Button>().interactable = false;
            object3.GetComponent<Button>().interactable = false;

            //message =" Hay aksi! " +correctcount+ " adet doðru "+falsecount+ " adet yanlýþýn var. Atýklarýn özelliklerini yeniden düþünmelisin. ";
        }
        //feedback.transform.GetChild(0).GetComponent<Text>().text = message;
        //feedback.SetActive(true);
        //kontrol.gameObject.SetActive(false);
        Next.gameObject.SetActive(false);

 
        
    }
    /*
    IEnumerator Sonraac()
    {
        yield return new WaitForSeconds(1.5f);
        instructýon.SetActive(false);
    }
    */
    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    



}
