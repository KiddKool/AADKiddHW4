﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text Score;

    void Start()
    {
        Score.text = PlayerPrefs.GetInt("PinCount").ToString();
    }


}
