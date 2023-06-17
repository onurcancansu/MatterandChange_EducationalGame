using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Slider : MonoBehaviour
{
    
    [SerializeField] public Slider s;
    public GameObject icecream;
    [SerializeField] public Image icecreamimage;
    [SerializeField] public Sprite[] meltingstate;
    private int value;
    public void work()
    {
        StartCoroutine(startanim());
    }
    IEnumerator startanim()
    {
        icecream.GetComponent<Slider>().enabled = true;
        yield return new WaitForSeconds(2);
        icecream.GetComponent<Slider>().enabled = false;

    }
    public void slidercontroller()
    {

        Debug.Log("Slider yeni deðeri: " + s.value);
        icecreamimage.sprite = meltingstate[(int)s.value];
    }
    
}
