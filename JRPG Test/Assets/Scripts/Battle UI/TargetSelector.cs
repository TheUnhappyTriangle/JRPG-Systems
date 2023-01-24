using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetSelector : MonoBehaviour
{
    public string actionName;
    public int activeCombatantIndex;
    public Text targetName;

    public void OnSelect()
    {
        // player does the selected attack via battle manager
    }
}
