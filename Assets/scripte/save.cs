using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class save : MonoBehaviour
{
    public float X, Y;
    private Transform player;
    void Start()
    {
        player = GetComponent<Transform>();
        Load();
    }

    void Update()
    {
        X = player.transform.position.x;
        Y = player.transform.position.y;
        Save();
    }
    public void Save()
    {
        PlayerPrefs.SetFloat("X", X);
        PlayerPrefs.SetFloat("Y", Y);
        PlayerPrefs.Save();
    }
    public void Load()
    {
        if (PlayerPrefs.HasKey("X"))
        {
            X = PlayerPrefs.GetFloat("X");
        }
        if (PlayerPrefs.HasKey("Y"))
        {
            Y = PlayerPrefs.GetFloat("Y");
        }
        player.transform.position = new Vector2(X, Y);
    }
}