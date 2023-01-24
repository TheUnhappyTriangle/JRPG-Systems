using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
    public static BattleManager instance;
    private bool battling;
    public GameObject battleScene;
    public List<Transform> allyPositions, enemyPositions;
    // public Combatant[] prefabs

}
