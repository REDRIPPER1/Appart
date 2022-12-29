using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class Maneger : MonoBehaviour
{
    public string[] dialouges;

    public int current_dialogue = 0;

    public TextMeshProUGUI text_object;

    void Start()
    {
        // SET THE TEXT TO FIRST DIALOGUE.
    }

    public void next_dialogue()
    {
        // INCREASE CURR DIALOGUE BY 1


        // SET THE DIALOGUE TEXT.
    }

}

// HINTS
// 1) create a public variable of type TextMeshProUGUI.
// 2) fill the variable in inspector with the dialogue text
// 3) on click then set the variable.text to dialogue..
