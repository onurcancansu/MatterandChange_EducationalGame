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
    //public GameObject instruct�on;
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
                if (waste.GetComponent<Drop>().isins�de)
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
            Debug.Log("do�ru say�s�" + correctcount);
            feedbackpositive.gameObject.SetActive(true);
            kontrol.GetComponent<Button>().interactable = false;
            object1.GetComponent<Button>().interactable = false;
            object2.GetComponent<Button>().interactable = false;
            object3.GetComponent<Button>().interactable = false;
            //message=" S�per! Tamam�n� do�ru yapt�n! 6 adet at��� t�rlerine g�re ay�r�p, do�ru ��p kutular�na yerle�tirebildin ";



        }
        else
        {
            Debug.Log("do�ru say�s�" + correctcount);

            feedbacknegative.gameObject.SetActive(true);
            kontrol.GetComponent<Button>().interactable = false;
            object1.GetComponent<Button>().interactable = false;
            object2.GetComponent<Button>().interactable = false;
            object3.GetComponent<Button>().interactable = false;

            //message =" Hay aksi! " +correctcount+ " adet do�ru "+falsecount+ " adet yanl���n var. At�klar�n �zelliklerini yeniden d���nmelisin. ";
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
        instruct�on.SetActive(false);
    }
    */
    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
    }
    



}
