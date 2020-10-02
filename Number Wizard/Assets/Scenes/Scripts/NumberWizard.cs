using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max;
    int min;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();

    }

    void StartGame()
    {
        
        min = 1;
        max = 1000;
        guess = 500;
        print("===========================");
        print("Welcome to Number Wizard...");
        print("Pick a number in your head but dont tell me!");

        print("The highest number you can pick is " + max);
        print("The lowest number you can pick is " + min);

        print("Is the number higher or lower than " + guess + " ?");
        print("Up = higher, down = lower, return = equal");

        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        } else if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            StartGame();
        }
    }

    void NextGuess()
    {
        guess = (min + max) / 2;
        print("Higher or lower than " + guess);
        print("Up = higher, down = lower, return = equal");
    }

}
