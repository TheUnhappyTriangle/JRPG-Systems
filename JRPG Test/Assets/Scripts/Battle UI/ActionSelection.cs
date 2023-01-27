using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
    This class represents the action that the hypothetical menu cursor is hovering over.
    When the Action is selected, a check is done to see if the combatant has enough of the correct resource (HP, MP, etc.).
    If there is enough to cover the cost, the combatant moves on to target selection.
*/

public class ActionSelection : MonoBehaviour // BattleActionSelector
{
    public string actionName;
    public int actionCost;
    public Text nameText, costText;

    public void OnSelect()
    {
        // if active combatant has enough health/magic, take away the cost and allow a target to be chosen
        // else send "not enough X" message
    }
}
