using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{

    //public type[] nameOfArray = new type[insert number here]
    //or
    //type[] nameOfArray = { , , , , ,};

    public GameObject[] levels = new GameObject[6];


    private void Start() {
        levels = GameObject.FindGameObjectsWithTag("Level");

        for (int i = 0; i < levels.Length; i++)
        {
            Debug.Log("This is Level " + i + " of 6, ");
        }
    }

}
