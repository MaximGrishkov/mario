using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject pausemenu;
    public static bool pausee;

    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(pausee)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void Pause()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        pausee = true;
    }
    public void Resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        pausee = false;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("home");
    }
}