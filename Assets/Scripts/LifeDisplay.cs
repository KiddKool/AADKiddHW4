using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeDisplay : MonoBehaviour
{
    public Dropdown dropdown;
    public static int Lives;

    public void LifeMenu()
    {
        switch (dropdown.value)
        {
            case 1:
                PlayerPrefs.SetInt("Lives", 1);
                break;
            case 2:
                PlayerPrefs.SetInt("Lives", 2);
                break;
            case 3:
                PlayerPrefs.SetInt("Lives", 3);
                break;

        }
    }
}
