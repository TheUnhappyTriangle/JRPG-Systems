using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This class represents an active unit in a battle or party. 
    Has a fade function which currently causes the Combatant sprite to fade to red... might need a lot of change after some testing to be more modular
    maybe it could work with ActionFX?
*/

public class Combatant : MonoBehaviour // Battler
{
    public bool isPlayer;
    public List<string> actionsAvailable = new List<string>();
    public string combatantName;
    public int currentHealth, currentMagic, maxHealth, maxMagic, strength, dexterity, constitution, intelligence, wisdom, charisma;
    public SpriteRenderer spriteRenderer;
    public Sprite deadSpr, aliveSpr;

    private bool shouldFade;
    public float fadeSpeed = 1.0f;

    // Update is called once per frame
    void Update()
    {
        if (shouldFade) Fade();
    }

    void Fade() 
    {
        spriteRenderer.color = new Color(Mathf.MoveTowards(spriteRenderer.color.r, 1f, fadeSpeed * Time.deltaTime),
                                         Mathf.MoveTowards(spriteRenderer.color.g, 0f, fadeSpeed * Time.deltaTime),
                                         Mathf.MoveTowards(spriteRenderer.color.b, 0f, fadeSpeed * Time.deltaTime),
                                         Mathf.MoveTowards(spriteRenderer.color.r, 0f, fadeSpeed * Time.deltaTime));
        if(spriteRenderer.color.a == 0)
        {
            gameObject.SetActive(false);
        }
    }

    public void EnemyFade()
    {
        shouldFade = true;
    }
}
