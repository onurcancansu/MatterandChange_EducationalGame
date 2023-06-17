using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class navigation : MonoBehaviour
{

    public void Forward()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void Backward()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    private bool isKey4Pressed = false;
    private bool isKey5Pressed = false;
    //public string nextSceneName; // Bir sonraki sahnenin ad�n� buraya girin

    void Update()
    {
        // �kili tu� kombinasyonunu alg�lamak i�in her iki tu�a da bas�l�p bas�lmad���n� kontrol ediyoruz
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            isKey4Pressed = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            isKey5Pressed = true;
        }

        // Her iki tu�a da bas�ld�ysa bir sonraki sahneye ge�iyoruz
        if (isKey4Pressed && isKey5Pressed)
        {
            SwitchToNextScene();
        }
    }

    void SwitchToNextScene()
    {
        // Bir sonraki sahneye ge�i�
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("oyundan ��kt�n�z");
    }
}
