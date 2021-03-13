using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Name : MonoBehaviour
{

    public Text nameDisplay;
 
    private void Start()
    {
        nameDisplay.text = PlayerPrefs.GetString("Player");
    }


}
