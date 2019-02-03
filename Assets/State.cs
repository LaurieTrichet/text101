using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{

    [TextArea(10,14)][SerializeField] string storyText;

    [SerializeField] State[] nextStates;

    public State[] NextStates
    {
        get
        {
            return nextStates;
        }
    }

    public string Story {
        get
        {
            return storyText;
        }  
    }
}
