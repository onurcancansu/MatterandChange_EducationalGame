using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sevenscript : MonoBehaviour
{
    public GameObject ice;
    public GameObject buhar;
    public GameObject balon;
    public GameObject balon1;
    public GameObject balon2;
    public GameObject button;
    public GameObject notebook;

    
  

    public void work()
    {
        StartCoroutine(surelicalýstýr());
    }
    IEnumerator surelicalýstýr()
    {
        ice.GetComponent<Animator>().enabled = true;
        yield return new WaitForSeconds(5);
        ice.GetComponent<Animator>().enabled = false;
        ice.SetActive(false);
        buhar.SetActive(true);
        balon.SetActive(true);
        balon1.SetActive(true);
        balon2.SetActive(true);
        notebook.SetActive(true);
        







    }
}
