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
    //public GameObject instruct�on;
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
                
                if (waste.GetComponent<termo>().isins�de)
                {
                    
                    falsecount++;
                    waste.GetComponent<termo>().backtostart();
                    

                }
            }
        }
        //string message ="";
        if (correctcount == Wastes.Length)
        {
            Debug.Log("do�ru say�s�" + correctcount);
            feedback1.gameObject.SetActive(true);
            kontrol1.GetComponent<Button>().interactable = false;
           
            //message=" S�per! Tamam�n� do�ru yapt�n! 6 adet at��� t�rlerine g�re ay�r�p, do�ru ��p kutular�na yerle�tirebildin ";



        }
        else
        {
            Debug.Log("do�ru say�s�" + correctcount);
            feedbacknegative1.gameObject.SetActive(true);
            correctcount = 0;
            //kontrol.GetComponent<Button>().interactable = false;
            

            //message =" Hay aksi! " +correctcount+ " adet do�ru "+falsecount+ " adet yanl���n var. At�klar�n �zelliklerini yeniden d���nmelisin. ";
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
        instruct�on.SetActive(false);
    }
    */
    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
    }




}

