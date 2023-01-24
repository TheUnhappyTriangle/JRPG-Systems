using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combatant : MonoBehaviour
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
