using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This class describes what the battle will be like.
    What opponents will be in the battle, what allies, and what rewards the player will receive.
    Maybe can put OST and other things like that in here.
*/

[System.Serializable]
public class BattleAttributes
{
    public List<string> opponents, allies, rewardItems;
    public bool ableToRun;
}
