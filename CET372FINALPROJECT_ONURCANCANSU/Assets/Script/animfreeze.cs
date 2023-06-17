using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animfreeze : MonoBehaviour
{
    public GameObject ice;
    public GameObject carafe;
    public GameObject box;
    public Button button;
    public GameObject lemonade;
    public GameObject lemonade1;
    public GameObject smallsoup;
    public GameObject next;
    public GameObject termo;
    public GameObject termo_soup;
    public GameObject termotxt_water;
    public GameObject termotxt_soup;
    public Button open;

    public void Start()
    {
        smallsoup.SetActive(false);
        
    }
    public void work()
    {
        StartCoroutine(surelicalýstýr());
    }
    IEnumerator surelicalýstýr()
    {
        ice.GetComponent<Animator>().enabled = true;
        carafe.GetComponent<Animator>().enabled = true;
        open.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(5);
        ice.GetComponent<Animator>().enabled = false;
        carafe.GetComponent<Animator>().enabled = false;
        button.GetComponent<Button>().interactable = true;
        ice.SetActive(false);
        carafe.SetActive(false);
        box.SetActive(false);
        smallsoup.SetActive(true);
        termotxt_soup.SetActive(true);
        termo_soup.SetActive(true);
        //yield return new WaitForSeconds(5);


        //button.SetActive(false);
        lemonade.SetActive(false);
        yield return new WaitForSeconds(2);
        //lemonade.SetActive(true);
        lemonade1.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        next.SetActive(true);
        
        termotxt_water.SetActive(true);
        termo.SetActive(true);
        
        
       
        
    }
}
