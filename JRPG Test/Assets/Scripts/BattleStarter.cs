using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This class keeps track of if it is time to begin a battle or encounter depending on what the player is doing.
    Presumably, the battleAttributes list will be randomized from a table or hard coded depending on the encounter zone.
*/

public class BattleStarter : MonoBehaviour // EncounterStarter
{
    public BattleAttributes[] battleAttributes;
    public bool encounterOnEnter, encounterOnStay, encounterOnExit, deactivateObj;
    private bool playerInEncounterZone;
    public float encounterTime = 10f;
    private float encounterTimer;

    // Start is called before the first frame update
    void Start()
    {
        encounterTimer = Random.Range(encounterTime * .5f, encounterTime * 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        // if player can move & is in encounter zone
            // if player is moving bring timer closer to 0
            // if timer hits zero reset it and begin StartBattle Coroutine
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (encounterOnEnter) { StartCoroutine(StartEncounter()); }
            else { playerInEncounterZone = true; }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            if (encounterOnExit) { StartCoroutine(StartEncounter()); }
            else { playerInEncounterZone = true; }
        }
    }

    public IEnumerator StartEncounter()
    {
        yield return new WaitForSeconds(1.5f);
    }
}
