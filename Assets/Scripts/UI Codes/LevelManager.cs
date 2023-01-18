using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class LevelManager : MonoBehaviour
{
    public Button Level1_button, Level2_button, Level3_button;
    public static bool Level1, Level2, Level3;

    private void Start()
    {
        Level1 = true;

    }

    private void Update()
    {
        if (Level2 == true)
        {
            Level2_button.interactable = true;
        }

        if (Level3 == true)
        {
            Level3_button.interactable = true;
        }
    }
}
