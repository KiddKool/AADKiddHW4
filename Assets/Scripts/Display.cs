using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Display : MonoBehaviour
{
    public InputField input;

    public void setName()
    {
        PlayerPrefs.SetString("Player", input.text);
    }
}
