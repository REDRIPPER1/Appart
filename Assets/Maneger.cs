using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class Maneger : MonoBehaviour
{
    public string[] dialouge;
    public TextMeshProUGUI dialogue_text; 
    // Start is called before the first frame update
    void Start()
    {
        dialogue_text.text = "wow coding";
    }

    // Update is called once per frame
    void Update()
    {
    }
}
