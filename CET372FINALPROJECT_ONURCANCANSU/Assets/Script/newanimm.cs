using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newanimm : MonoBehaviour
{
    public GameObject ice;
    public GameObject button;
    public GameObject lemonade;
    public GameObject lemonade1;
    public GameObject nextbutton;
    public GameObject buhar;
    public GameObject balon;
    public GameObject balon1;
    public GameObject balon2;
    public void work()
    {
        StartCoroutine(surelicalýstýr());
    }
    
    IEnumerator surelicalýstýr()
    {
        ice.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(3);
        ice.GetComponent<Animator>().enabled = false;
        nextbutton.SetActive(true);
        //button.SetActive(false);
        ice.SetActive(false);
        buhar.SetActive(true);
        balon.SetActive(true);
        balon1.SetActive(true);
        balon2.SetActive(true);
        lemonade.SetActive(false);
        lemonade1.SetActive(true);
        
        
        yield return new WaitForSeconds(2);
        lemonade1.SetActive(true);        
    }
}
