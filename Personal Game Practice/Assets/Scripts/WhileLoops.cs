using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhileLoops : MonoBehaviour {

public int enemies;

	// Use this for initialization
	void Start () {
	
		while(enemies > 0)
        {
            print("Don't forget: There are enemies in the room, so be careful");
            enemies--;
        }
	}
}