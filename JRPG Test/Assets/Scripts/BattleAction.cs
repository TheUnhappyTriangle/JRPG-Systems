using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This class represents an Action that is known by a Combatant who can then use them in a battle.
    They can be an attack or spell, or a more peaceful action like a dance or a wave.
*/ 

//public enum ActionType { Attack, Spell, Action }
[System.Serializable]
public class BattleAction
{
    public string actionName;
    public int actionPower;
    public int actionCost;
    // public ActionFX theEffect;
}
