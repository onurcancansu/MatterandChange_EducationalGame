using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{
    public GameObject[] Wastes;
    public GameObject feedback1;
    public GameObject feedbacknegative1;
    public GameObject object11;
    public GameObject object21;
    public GameObject object31;
    public GameObject object4;
    public GameObject object5;
    public GameObject object6;
    //public GameObject instructýon;
    public Button Next1;
    public Button kontrol1;

    //public Text t1;
    //public Text t2;
    //public GameObject gameover;
    public int correctcount = 0;
    public int falsecount = 0;

    void Start()
    {
        //StartCoroutine(Sonraac());
        //feedback.SetActive(false);
        kontrol1.GetComponent<Button>().interactable = false;
        //object11.GetComponent<Button>().interactable = false;
        //object21.GetComponent<Button>().interactable = false;
        //object31.GetComponent<Button>().interactable = false;
        //object4.GetComponent<Button>().interactable = false;
        //object5.GetComponent<Button>().interactable = false;
        //object6.GetComponent<Button>().interactable = false;
     

    }

    public void controlet()
    {
        //Debug.Log("okey");
        //Debug.Log("mathcing : " + wastes[0].GetComponent<Drag>().iscorrectmatch);

        foreach (GameObject waste in Wastes)
        {
            
            //Debug.Log("matching foreach :" + waste.GetComponent<Drop>().iscorrectmatch);
            if (waste.GetComponent<termo>().iscorrectmatch)
            {
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
        //string message ="";
        if (correctcount == Wastes.Length)
        {
            Debug.Log("doðru sayýsý" + correctcount);
            feedback1.gameObject.SetActive(true);
            kontrol1.GetComponent<Button>().interactable = false;
           
            //message=" Süper! Tamamýný doðru yaptýn! 6 adet atýðý türlerine göre ayýrýp, doðru çöp kutularýna yerleþtirebildin ";



        }
        else
        {
            Debug.Log("doðru sayýsý" + correctcount);
            feedbacknegative1.gameObject.SetActive(true);
            correctcount = 0;
            //kontrol.GetComponent<Button>().interactable = false;
            

            //message =" Hay aksi! " +correctcount+ " adet doðru "+falsecount+ " adet yanlýþýn var. Atýklarýn özelliklerini yeniden düþünmelisin. ";
        }
        //feedback.transform.GetChild(0).GetComponent<Text>().text = message;
        //feedback.SetActive(true);
        //kontrol.gameObject.SetActive(false);
        Next1.gameObject.SetActive(false);



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

