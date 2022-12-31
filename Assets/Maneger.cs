using UnityEngine;
using TMPro; 
public class Maneger : MonoBehaviour
{
    public string[] dialogues;

    public int current_dialogue = 0;

    public TextMeshProUGUI text_object;
    public Sprite Bedroom_Pic;
    public SpriteRenderer Background_object;
        public Sprite waifupic;
    public SpriteRenderer Waifu_object;


    void Start()
    {
        text_object.text= dialogues[current_dialogue];
    }
  public int x;
    public void next_dialogue()
    {
        // INCREASEd CURR DIALOGUE BY 1
       if(current_dialogue<10)
        {

        
 text_object.text= dialogues[current_dialogue];
 current_dialogue++;
        }
        if(current_dialogue>8)
        {
            Waifu_object.sprite=waifupic;
            Background_object.sprite=Bedroom_Pic;
        }
        // SET THE DIALOGUE TEXT.
    }
}

