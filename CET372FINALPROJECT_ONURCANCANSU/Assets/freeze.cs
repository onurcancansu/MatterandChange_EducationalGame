using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class freeze : MonoBehaviour
{
    public GameObject water;
    public GameObject cube1;
    public GameObject cube2;
    public Button open;
    public GameObject next;

    public void work()
    {
        StartCoroutine(sureliworks());
    }
    IEnumerator sureliworks()
    {
        water.GetComponent<Animator>().enabled = true;
        //open.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(5);
        water.GetComponent<Animator>().enabled = false;
        //open.GetComponent<Button>().interactable = true;
        water.SetActive(false);

        //yield return new WaitForSeconds(5);
        cube1.SetActive(false);
        yield return new WaitForSeconds(2);
        cube1.SetActive(true);
        cube2.SetActive(true);
        open.GetComponent<Button>().interactable = false;
        yield return new WaitForSeconds(0.5f);
        next.SetActive(true);
    



    }
}
