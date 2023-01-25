using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
    This class is a singleton which represents the screen that occurs at the end of a battle.
    It will show the player how much exp they received, what items they have earned, and whether quests have been updated.
*/

public class BattleReward : MonoBehaviour // BattleRewardScreen
{
    public static BattleReward Instance { get; private set; }
    public Text expText, itemText;
    public GameObject rewardScreen;

    public int expEarned;
    public List<string> rewardedItems = new List<string>();
    
    //quest info

    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y)) // debug button
        {
            OpenRewardsScreen(54, new List<string> { "Iron sword", "Iron Armor" });
        }
    }

    public void OpenRewardsScreen(int exp, List<string> items)
    {
        expEarned = exp;
        rewardedItems = items;

        expText.text = "The party gained " + expEarned + " experience points!";
        itemText.text = "";
        foreach (string item in rewardedItems) 
        {
            itemText.text += item + ",\n";
        }

        rewardScreen.SetActive(true);
    }

    public void CloseRewardsScreen() 
    {

        rewardScreen.SetActive(false);
        // GameManager battle active -> false
    }
}
