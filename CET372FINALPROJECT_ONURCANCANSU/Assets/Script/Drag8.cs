using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag8 : MonoBehaviour
{
    Vector3 startpos;

    public bool isins�de = false;
    public string hedeftag = "melting";
    public bool iscorrectmatch = false;
    public GameObject button;
    public GameObject button1;

    // Start is called before the first frame update
    void Start()
    {
        startpos = this.transform.position;

    }

    void OnMouseDrag()
    {
        Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(newpos.x, newpos.y, 0);

    }

    void OnMouseUp()
    {
        if (!isins�de)
            backtostart();
        button.SetActive(false);

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("��eride");
        isins�de = true;
        if (collision.gameObject.tag == hedeftag)
        {
            iscorrectmatch = true;
            button.SetActive(true);
            
            


        }
       
        
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        iscorrectmatch = false;
        //Debug.Log("��erden ��kt�");
        //isins�de = false;

    }
    public void backtostart()
    {
        this.transform.position = startpos;
        //button.SetActive(false);
        //button1.SetActive(false);

    }
}
