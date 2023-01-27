using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
    This class represents the target for an action that the hypothetical menu cursor is hovering over.
    When the target is selected, the battle manager is contacted to figure out what needs to occur.
*/

public class TargetSelection : MonoBehaviour
{
    public string actionName;
    public int activeCombatantIndex;
    public Text targetName;

    public void OnSelect()
    {
        // player does the selected attack via battle manager
    }
}
