using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
    This class is the nexus point for all things that occur in a battle.
*/

public class BattleManager : MonoBehaviour
{
    public static BattleManager Instance { get; private set; }
    private bool battleOccuring;

    public GameObject battleScene;
    public List<Transform> allyPositions, enemyPositions;
    public List<Combatant> allyPrefabs, enemyPrefabs;
    public List<Combatant> activeCombatants = new List<Combatant>();
    public int turnCount = 0;
    public bool playerTurn;

    public GameObject battleUI;
    public List<BattleAction> actionList;
    
    public GameObject attackEffect;
    public DamageValue damageValue;
    public List<Text> allyName, allyHP, allyMP;

    public GameObject targetMenu;
    public List<TargetSelection> targetChoices;
    public GameObject mageMenu;
    public List<ActionSelection> mageChoices;
    public GameObject skillMenu;
    public List<ActionSelection> skillChoices;

    public BattleMessage battleMessage;

    public int escapeOdds = 35;
    private bool escaping;

    public string gameOverScreen;
    public int rewardEXP;
    public List<string> rewardItems;

    public bool escapable;

    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    void Update()
    {
        
    }

    public void BattleStart (List<string> enemies, bool setEscapable)
    {
        if (!battleOccuring)
        {
            escapable = setEscapable;
            battleOccuring = true;
            //GameManager.i.battleActive = true
            transform.position = new Vector3(Camera.main.transform.position.x,
                                             Camera.main.transform.position.y,
                                             Camera.main.transform.position.z);
            battleScene.SetActive(true);

            // begin battle music

            for (int i = 0; i < allyPositions.Count; i++)
            {
                
            }
        }
    }
}
