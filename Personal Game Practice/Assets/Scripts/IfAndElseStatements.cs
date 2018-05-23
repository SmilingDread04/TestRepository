using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Contains code for Triggers/Colliders & If/Else Statements
public class IfAndElseStatements : MonoBehaviour
{

    [SerializeField] private string loadLevel;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "Red")
        {
            GetComponent<Renderer>().material.color = Color.red;
            Destroy(col.gameObject);
            Debug.Log("Red");
        }

        else if (col.gameObject.name == "Green")
        {
            GetComponent<Renderer>().material.color = Color.green;
            Destroy(col.gameObject);
            Debug.Log("Green");
        }

        else if (col.gameObject.name == "Blue")
        {
            GetComponent<Renderer>().material.color = Color.blue;
            Destroy(col.gameObject);
            Debug.Log("Blue");
        }

        else if (col.gameObject.name == "Secret Movie")
        {

        }

        else if (col.CompareTag("Player"))
        {
            SceneManager.LoadScene(loadLevel);
            Debug.Log("Loaded Level");
        }
    }

}
