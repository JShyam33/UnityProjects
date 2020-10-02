using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{

    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Press space";               
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            text.text = "You are a Wizard named Roy.\n\n You are in your room.\n "+
                        "There's old unknown book in front of you " +
                        "And the door to your room\n\n "+
                        "What is your choice...\n"+
                        "Press B to open Book, D to open Door and go outside the room.";
            
        }
    }
}
