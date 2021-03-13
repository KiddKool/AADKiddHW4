using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour
{
    public Text PlayerLife;
    void Start()
    {
        PlayerLife.text = PlayerPrefs.GetInt("Lives").ToString();
    }


}
