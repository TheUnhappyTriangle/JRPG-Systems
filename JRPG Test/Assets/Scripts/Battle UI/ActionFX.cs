using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This class represents the effect that occurs when an active Combatant successfully does an Action
    A sound effect and animation will play out from the start method.
    The effect will be destroyed after a certain amount of time.
*/

public class ActionFX : MonoBehaviour // BattleActionFX
{
    public float fxDuration;
    // public int sfxIndex;

    // Start is called before the first frame update
    void Start()
    {
        // play sound effect
        // play animation
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, fxDuration);
    }
}
