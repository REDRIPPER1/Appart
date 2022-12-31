using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class Maneger : MonoBehaviour
{
    public string[] dialogues;

    public int current_dialogue = 0;

    public TextMeshProUGUI text_object;

    void Start()
    {
        text_object.text= dialogues[current_dialogue];
    }

    public void next_dialogue()
    {
        // INCREASEd CURR DIALOGUE BY 1
        while(current_dialogue<10)
        {
current_dialogue++;
        }
 text_object.text= dialogues[current_dialogue];
        // SET THE DIALOGUE TEXT.
    }

}

