using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Contains coding for Power Ups/Power Downs & Scope/Access Modifiers
public class TilePowers : MonoBehaviour {

    public MoveCharacter stats;

    private void OnDestroy()
    {
        {
            if (gameObject.name == "Red")
            {
                stats.gravity = 10.0F;  
            }

            else if (gameObject.name == "Green")
            {
                stats.jumpSpeed = 16.0F;
            }

            else if (gameObject.name == "Blue")
            {
                stats.speed = 12.0F;
            }
        }
    }

}
