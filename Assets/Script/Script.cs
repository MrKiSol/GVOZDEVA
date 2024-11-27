using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Script : MonoBehaviour
{
    [SerializeField] int money;
    public Text moneyText;
    public void ButtonClick()
    {
        PlayerPrefs.SetInt("money", money++);
    }

    void Update()
    {
        moneyText.text = money.ToString();
    }
}