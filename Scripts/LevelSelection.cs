using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelection : MonoBehaviour
{
    public levelSelect levelSelection;
    // Start is called before the first frame update
    void Start()
    {
        switch (levelSelection) 
        {
            case levelSelect.Tutorial:
                Debug.Log("This is the tutorial");
                break;
            case levelSelect.Midgame:
                Debug.Log("This is the midgame");
                break;
            case levelSelect.Lategame:
                Debug.Log("This is the lategame");
                break;
            case levelSelect.EndGame:
                Debug.Log("This is the endgame");
                break;
        }
    }

    // Update is called once per frame
    public enum levelSelect
    {
        Tutorial,
        Midgame,
        Lategame,
        EndGame,
    }
}
