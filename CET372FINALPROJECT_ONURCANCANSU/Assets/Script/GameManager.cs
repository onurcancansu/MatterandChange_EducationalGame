using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
    public GameObject machine;
    public GameObject machine1;
    public GameObject machine2;
    public GameObject button;
    public GameObject button1;
    public GameObject button2;
    public GameObject panel;
    public GameObject control_btn;

    public void Start()
    {
        control_btn.GetComponent<Button>().interactable = false;
    }

    public void works()
    {
        StartCoroutine(surelicalýstýr());
    }
    IEnumerator surelicalýstýr()
    {
        machine.GetComponent<Animator>().enabled = true;
        button1.GetComponent<Button>().interactable = false;
        button2.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(2);
        machine.GetComponent<Animator>().enabled = false;
        button1.GetComponent<Button>().interactable = true;
        button2.GetComponent<Button>().interactable = true;
    }
    public void workswater()
    {
        StartCoroutine(surelicalýstýr1());
    }
    IEnumerator surelicalýstýr1()
    {
        machine1.GetComponent<Animator>().enabled = true;
        button.GetComponent<Button>().interactable = false;
        button2.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(2);
        machine1.GetComponent<Animator>().enabled = false;
        button.GetComponent<Button>().interactable = true;
        button2.GetComponent<Button>().interactable = true;
    }
    public void worksvapor()
    {
        StartCoroutine(surelicalýstýr2());
    }
    IEnumerator surelicalýstýr2()
    {
        machine2.GetComponent<Animator>().enabled = true;
        button.GetComponent<Button>().interactable = false;
        button1.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(2);
        machine2.GetComponent<Animator>().enabled = false;
        button.GetComponent<Button>().interactable = false;
        button1.GetComponent<Button>().interactable = false;
        button2.GetComponent<Button>().interactable = true;
        button.GetComponent<Button>().interactable = true;
        button1.GetComponent<Button>().interactable = true;
    }
}
