using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim3 : MonoBehaviour
{
    public GameObject ice;
    public GameObject button;
    public GameObject lemonade;
    public GameObject lemonade1;
    public GameObject nextbutton;

    public void work()
    {
        StartCoroutine(surelicalýstýr());
    }

    IEnumerator surelicalýstýr()
    {
       
        ice.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(3);
        ice.GetComponent<Animator>().enabled = false;
        ice.SetActive(false);
        lemonade.SetActive(false);
        yield return new WaitForSeconds(2);
        //lemonade.SetActive(true);
        lemonade1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        nextbutton.SetActive(true);
        //button.SetActive(false);
        
        lemonade.SetActive(false);
        /*
        buhar.SetActive(true);
        balon.SetActive(true);
        balon1.SetActive(true);
        balon2.SetActive(true);*/

        //lemonade1.SetActive(true);


        yield return new WaitForSeconds(2);
        lemonade1.SetActive(true);
    }
}
