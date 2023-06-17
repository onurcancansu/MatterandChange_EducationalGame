using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animfreeze2 : MonoBehaviour
{
    
    public GameObject icemold;
    public GameObject icemold1;
    public GameObject fridge;
    public GameObject fridge1;
    public GameObject next;
    public GameObject button;
    public void work()
    {
        StartCoroutine(surelicalýstýr());
    }
    IEnumerator surelicalýstýr()
    {
        /*
        icemold.SetActive(true);
        fridge.SetActive(true);*/
        yield return new WaitForSeconds(2);
        icemold.SetActive(false);
        fridge.SetActive(false);
        yield return new WaitForSeconds(0.12f);
        icemold1.SetActive(true);
        fridge1.SetActive(true);
        
        yield return new WaitForSeconds(0.5f);
        button.SetActive(false);
        next.SetActive(true);
    }
}
