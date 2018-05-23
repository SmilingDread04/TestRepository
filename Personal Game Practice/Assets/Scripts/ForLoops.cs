using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForLoops : MonoBehaviour {
    
	public int tiles;
    
    void Start ()
    {
        for(int i = 0; i < tiles; i++)
        {
            print("There are " + i + " Tile Power Ups for grabs!");
        }
    }
}
