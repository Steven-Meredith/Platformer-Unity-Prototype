using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDialogue : MonoBehaviour
{
    public levelSelection levelStage;

    // Start is called before the first frame update
    void Start()
    {
        switch (levelStage)
        {
            case levelSelection.Tutorial:
                Debug.Log("Welcome to the Sleepy Sidewinder");
                break;
            case levelSelection.Middle:
                Debug.Log("Enemies will begin to follow you now");
                break;
            case levelSelection.Final:
                Debug.Log("Good luck against the final boss");
                break;
            case levelSelection.HiddenEnding:
                Debug.Log("Hopefully you collected all of the hearts.... or else");
                    break;
        }

            
    }
    public enum levelSelection
    {
        Tutorial,
        Middle,
        Final,
        HiddenEnding,
    }

    // Update is called once per frame
    
}
