using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("lvl 1");
    }
    public void Options()
    {

    }
    public void Exit()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}