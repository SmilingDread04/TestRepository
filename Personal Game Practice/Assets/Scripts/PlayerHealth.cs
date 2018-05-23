using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
//Contains In-Game State Machine (not through animator) & Health Bar script 
public class PlayerHealth : MonoBehaviour
{

    public Slider healthbar;//Reference To Slider

    public static int health; //Health Of Player

    public enum State
    {
        Shameful,
        Easy,
        Medium,
        Hard,
        Psychotic
    }

    public State state;

    IEnumerator ShamefulState()
    {
        Debug.Log("Welcome to the Shameful Difficulty!");
        while (state == State.Shameful)
        {
            yield return 0;
        }
        Debug.Log("If you want to leave, then jump off of the stage!  Seriously, you'll be waiting for hours to die otherwise...");
        NextState();
    }

    IEnumerator EasyState()
    {
        Debug.Log("Welcome to the Easy Difficulty!");
        while (state == State.Easy)
        {
            yield return 0;
        }
        Debug.Log("If this is your first time, then enjoy the level!");
        NextState();
    }

    IEnumerator MediumState()
    {
        Debug.Log("Welcome to the Medium Difficulty!");
        while (state == State.Medium)
        {
            yield return 0;
        }
        Debug.Log("Ah, you must be the casual player.  How... casual.");
        NextState();
    }

    IEnumerator HardState()
    {
        Debug.Log("Welcome to the Hard Difficulty!");
        while (state == State.Hard)
        {
            yield return 0;
        }
        Debug.Log("Do you love a challenge?  Well, so do we!");
        NextState();
    }

    IEnumerator PsychoticState()
    {
        Debug.Log("Welcome to the Psychotic Difficulty!");
        while (state == State.Psychotic)
        {
            yield return 0;
        }
        Debug.Log("Hope you're a quick learner!  If not, you're screwed!");
        NextState();
    }

    // Use this for initialization
    void Start()
    {
        if (state == State.Shameful)
        {
            health = 9000000; //Max Health Of Player, Should Be Same As Max Slider Value
        }

        else if (state == State.Easy)
        {
            health = 4000; //Max Health Of Player, Should Be Same As Max Slider Value
        }

        else if (state == State.Medium)
        {
            health = 2000; //Max Health Of Player, Should Be Same As Max Slider Value
        }

        else if (state == State.Hard)
        {
            health = 1000; //Max Health Of Player, Should Be Same As Max Slider Value
        }

        else if (state == State.Psychotic)
        {
            health = 500; //Max Health Of Player, Should Be Same As Max Slider Value
        }
        NextState();
    }

    // Update is called once per frame
    void Update()
    {
        healthbar.value = health; //Update Slider's Value To Equal Player's Health

        ChangeHealth(); //Used If No Triggers Are Present
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("Player Cube")) { if (health > 0) health = health - 1; }//Stop Damaging Once Health Reaches 0
        if (other.gameObject.name.Equals("Green")) { if (health < 9000000) health = health + 100; }//Stops Healing Once Health Reaches 100
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name.Equals("Player Cube"))
        {
            if (health > 0)
            {
                health = health - 1;
            }

            else if (health == 0)
            {
                SceneManager.LoadScene("Title Screen");
            }
        }
    }
    void ChangeHealth()
    {
        if (Input.GetKeyDown(KeyCode.Z)) { if (health > 0) health = health - 20; }
        if (Input.GetKeyDown(KeyCode.X)) { if (health < 100) health = health + 20; }
    }

    void NextState()
    {
        string methodName = state.ToString() + "State";
        System.Reflection.MethodInfo info =
            GetType().GetMethod(methodName,
                                System.Reflection.BindingFlags.NonPublic |
                                System.Reflection.BindingFlags.Instance);
        StartCoroutine((IEnumerator)info.Invoke(this, null));
    }
}
