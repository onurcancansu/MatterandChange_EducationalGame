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
    //public string nextSceneName; // Bir sonraki sahnenin adýný buraya girin

    void Update()
    {
        // Ýkili tuþ kombinasyonunu algýlamak için her iki tuþa da basýlýp basýlmadýðýný kontrol ediyoruz
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            isKey4Pressed = true;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            isKey5Pressed = true;
        }

        // Her iki tuþa da basýldýysa bir sonraki sahneye geçiyoruz
        if (isKey4Pressed && isKey5Pressed)
        {
            SwitchToNextScene();
        }
    }

    void SwitchToNextScene()
    {
        // Bir sonraki sahneye geçiþ
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("oyundan çýktýnýz");
    }
}
