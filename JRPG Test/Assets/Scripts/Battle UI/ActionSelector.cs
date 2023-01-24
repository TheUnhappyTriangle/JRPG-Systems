using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionSelector : MonoBehaviour
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
