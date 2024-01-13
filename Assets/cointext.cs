using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cointext : MonoBehaviour
{
    public static int coin;
    Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }
    void Update()
    {
        text.text = coin.ToString();
    }
}