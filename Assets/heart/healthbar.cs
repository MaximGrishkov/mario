using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    [SerializeField] private Image healthBarTotal;
    [SerializeField] private Image healthBarCurrent;
    [SerializeField] private health current;
    void Start()
    {
        healthBarTotal.fillAmount = current.currentHealth/10;

    }

    // Update is called once per frame
    void Update()
    {
        healthBarCurrent.fillAmount = current.currentHealth / 10;
    }
}
