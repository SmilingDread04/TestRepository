using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForEachLoops : MonoBehaviour {

	void Start () 
    {
        string[] difficulties = new string[5];
        
        difficulties[0] = "Difficulty 1: Shameful";
        difficulties[1] = "Difficulty 2: Easy";
        difficulties[2] = "Difficulty 3: Medium";
        difficulties[3] = "Difficulty 4: Hard";
        difficulties[4] = "Difficulty 5: Psychotic";
        
        foreach(string item in difficulties)
        {
            print (item);
        }
    }
}
