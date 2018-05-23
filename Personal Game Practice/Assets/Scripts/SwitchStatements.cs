using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour
{

    public int LevelDescription;

    // Use this for initialization
    void Start()
    {
        switch (LevelDescription)
        {
            case 1:
                print("This is Level 1, A.K.A. the Tutorial Level. Learn the basic format of the game and get a chance to take in your surroundings");
                break;

            case 2:
                print("This is Level 2.  Hope you're an Astronaut, because this level is all about embracing the gravity!");
                break;

            case 3:
                print("This is Level 3.  Ever wanted to be like Luigi?  Well this level is all about jumping like Super Mario Bro!");
                break;

            case 4:
                print("This is Level 4. Ever wonder if we would combine the previous gimmicks?  Absolutely, which is why this level exists!");
                break;

            case 5:
                print("This is Level 5.  Don't worry, we'll go easier on your here.  This level is about speed and nothing but!");
                break;

            case 6:
                print("This is Level 6.  This is the culmination of all you've endured so far, so good luck!");
                break;

            default:
                print("Type the number of the level shown onscreen to read its' description.");
                break;
        }
    }
}
