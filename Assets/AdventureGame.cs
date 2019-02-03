using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] TMPro.TMP_Text title;
    [SerializeField] TMPro.TMP_Text description;
    [SerializeField] State startingState;

    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        description.text = startingState.Story;
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextStates = state.NextStates;
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStates[0];
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (nextStates.Length > 1)
            {
                state = nextStates[1];
            }
           
        }

        description.text = state.Story;
    }
}
