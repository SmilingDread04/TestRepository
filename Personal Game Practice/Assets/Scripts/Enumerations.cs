using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enumerations : MonoBehaviour
{
    public enum Difficulty {Title_Screen, Level_Select, Difficulty_Select_1, Difficulty_Select_2, Difficulty_Select_3, Difficulty_Select_4, Difficulty_Select_5, Difficulty_Select_6, Shameful_1, Easy_1, Medium_1, Hard_1, Psychotic_1, Shameful_2, Easy_2, Medium_2, Hard_2, Psychotic_2, Shameful_3, Easy_3, Medium_3, Hard_3, Psychotic_3, Shameful_4, Easy_4, Medium_4, Hard_4, Psychotic_4, Shameful_5, Easy_5, Medium_5, Hard_5, Psychotic_5, Shameful_6, Easy_6, Medium_6, Hard_6, Psychotic_6 };
    public Difficulty myDifficulty;
    // Update is called once per frame
    void Update()
    {
        if (myDifficulty == Difficulty.Title_Screen)
        {
            Title_Screen ();
        }
        
        else if (myDifficulty == Difficulty.Level_Select)
        {
            Level_Select ();
        }
        
        else if (myDifficulty == Difficulty.Difficulty_Select_1)
        {
            Difficulty_Select_1 ();
        }

        else if (myDifficulty == Difficulty.Difficulty_Select_2)
        {
            Difficulty_Select_2();
        }

        else if (myDifficulty == Difficulty.Difficulty_Select_3)
        {
            Difficulty_Select_3();
        }

        else if (myDifficulty == Difficulty.Difficulty_Select_4)
        {
            Difficulty_Select_4();
        }

        else if (myDifficulty == Difficulty.Difficulty_Select_5)
        {
            Difficulty_Select_5();
        }

        else if (myDifficulty == Difficulty.Difficulty_Select_6)
        {
            Difficulty_Select_6();
        }

        else if (myDifficulty == Difficulty.Shameful_1)
        {
            Shameful_1 ();
        }

        else if (myDifficulty == Difficulty.Shameful_2)
        {
            Shameful_2();
        }

        else if (myDifficulty == Difficulty.Shameful_3)
        {
            Shameful_3();
        }

        else if (myDifficulty == Difficulty.Shameful_4)
        {
            Shameful_4();
        }

        else if (myDifficulty == Difficulty.Shameful_5)
        {
            Shameful_5();
        }

        else if (myDifficulty == Difficulty.Shameful_6)
        {
            Shameful_6();
        }

        else if (myDifficulty == Difficulty.Easy_1)
        {
            Easy_1 ();
        }

        else if (myDifficulty == Difficulty.Easy_2)
        {
            Easy_2();
        }

        else if (myDifficulty == Difficulty.Easy_3)
        {
            Easy_3();
        }

        else if (myDifficulty == Difficulty.Easy_4)
        {
            Easy_4();
        }

        else if (myDifficulty == Difficulty.Easy_5)
        {
            Easy_5();
        }

        else if (myDifficulty == Difficulty.Easy_6)
        {
            Easy_6();
        }

        else if (myDifficulty == Difficulty.Medium_1)
        {
            Medium_1();
        }

        else if (myDifficulty == Difficulty.Medium_2)
        {
            Medium_2();
        }

        else if (myDifficulty == Difficulty.Medium_3)
        {
            Medium_3();
        }

        else if (myDifficulty == Difficulty.Medium_4)
        {
            Medium_4();
        }

        else if (myDifficulty == Difficulty.Medium_5)
        {
            Medium_5();
        }

        else if (myDifficulty == Difficulty.Medium_6)
        {
            Medium_6();
        }

        else if (myDifficulty == Difficulty.Hard_1)
        {
            Hard_1();
        }

        else if (myDifficulty == Difficulty.Hard_2)
        {
            Hard_2();
        }

        else if (myDifficulty == Difficulty.Hard_3)
        {
            Hard_3();
        }

        else if (myDifficulty == Difficulty.Hard_4)
        {
            Hard_4();
        }

        else if (myDifficulty == Difficulty.Hard_5)
        {
            Hard_5();
        }

        else if (myDifficulty == Difficulty.Hard_6)
        {
            Hard_6();
        }

        else if (myDifficulty == Difficulty.Psychotic_1)
        {
            Psychotic_1();
        }

        else if (myDifficulty == Difficulty.Psychotic_2)
        {
            Psychotic_2();
        }

        else if (myDifficulty == Difficulty.Psychotic_3)
        {
            Psychotic_3();
        }

        else if (myDifficulty == Difficulty.Psychotic_4)
        {
            Psychotic_4();
        }

        else if (myDifficulty == Difficulty.Psychotic_5)
        {
            Psychotic_5();
        }

        else if (myDifficulty == Difficulty.Psychotic_6)
        {
            Psychotic_6();
        }
    }

    void Title_Screen()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Level Select");
        }
    }
    void Level_Select()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene("Difficulty Select 1");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SceneManager.LoadScene("Difficulty Select 2");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SceneManager.LoadScene("Difficulty Select 3");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            SceneManager.LoadScene("Difficulty Select 4");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            SceneManager.LoadScene("Difficulty Select 5");
        }

        else if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            SceneManager.LoadScene("Difficulty Select 6");
        }
    }

    void Difficulty_Select_1()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("Shameful 1");
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Easy 1");
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Medium 1");
        }

        else if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("Hard 1");
        }

        else if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Psychotic 1");
        }
    }

    void Difficulty_Select_2()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("Shameful 2");
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Easy 2");
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Medium 2");
        }

        else if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("Hard 2");
        }

        else if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Psychotic 2");
        }
    }

    void Difficulty_Select_3()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("Shameful 3");
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Easy 3");
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Medium 3");
        }

        else if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("Hard 3");
        }

        else if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Psychotic 3");
        }
    }

    void Difficulty_Select_4()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("Shameful 4");
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Easy 4");
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Medium 4");
        }

        else if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("Hard 4");
        }

        else if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Psychotic 4");
        }
    }

    void Difficulty_Select_5()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("Shameful 5");
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Easy 5");
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Medium 5");
        }

        else if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("Hard 5");
        }

        else if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Psychotic 5");
        }
    }

    void Difficulty_Select_6()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            SceneManager.LoadScene("Shameful 6");
        }

        else if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Easy 6");
        }

        else if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("Medium 6");
        }

        else if (Input.GetKeyDown(KeyCode.H))
        {
            SceneManager.LoadScene("Hard 6");
        }

        else if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("Psychotic 6");
        }
    }


    void Shameful_1()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 1 Shameful");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Shameful_2()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 2 Shameful");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Shameful_3()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 3 Shameful");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Shameful_4()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 4 Shameful");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Shameful_5()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 5 Shameful");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Shameful_6()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 6 Shameful");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Easy_1()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 1 Easy");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Easy_2()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 2 Easy");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Easy_3()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 3 Easy");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Easy_4()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 4 Easy");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Easy_5()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 5 Easy");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Easy_6()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 6 Easy");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Medium_1()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 1 Medium");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Medium_2()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 2 Medium");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Medium_3()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 3 Medium");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Medium_4()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 4 Medium");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Medium_5()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 5 Medium");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Medium_6()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 6 Medium");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Hard_1()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 1 Hard");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Hard_2()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 2 Hard");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Hard_3()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 3 Hard");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Hard_4()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 4 Hard");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Hard_5()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 5 Hard");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Hard_6()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 6 Hard");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Psychotic_1()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 1 Psychotic");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Psychotic_2()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 2 Psychotic");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Psychotic_3()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 3 Psychotic");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Psychotic_4()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 4 Psychotic");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Psychotic_5()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 5 Psychotic");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }

    void Psychotic_6()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SceneManager.LoadScene("Level 6 Psychotic");
        }

        else if (Input.GetKeyDown(KeyCode.N))
        {
            SceneManager.LoadScene("Level Select");
        }
    }
}