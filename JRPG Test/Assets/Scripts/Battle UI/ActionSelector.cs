using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActionSelector : MonoBehaviour
{
    public string actionName;
    public int actionCost;
    public Text nameText, costText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSelect()
    {
        // if active combatant has enough health/magic, take away the cost and allow a target to be chosen
        // else send "not enough X" message
    }
}
