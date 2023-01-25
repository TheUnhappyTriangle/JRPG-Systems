using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This class is the nexus point for all things that occur in a battle.
*/

public class BattleManager : MonoBehaviour
{
    public static BattleManager Instance { get; private set; }
    private bool battling;
    public GameObject battleScene;
    public List<Transform> allyPositions, enemyPositions;
    // public Combatant[] prefabs

    private void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

}
