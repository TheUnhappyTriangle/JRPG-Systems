using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum expGainType { Slow, Medium, Fast };
public class CombatantStats : MonoBehaviour
{
    public string name, equipItem;
    public int levelCur, levelMax, 
               expCur, expInit,
               healthCur, healthMax, 
               magicCur, magicMax,
               strength, dexterity,
               constitution, intelligence,
               wisdom, charisma; // strength, bulk, intelligence, resolve, dexterity
    public int[] expEachLvl;
    public Sprite backSpr, frontSpr;

    private void Start()
    {
        expEachLvl = new int[levelMax];
        expEachLvl[1] = expInit;
        
        for (int i = 2; i < expEachLvl.Length; i++) 
        {
            expEachLvl[i] = Mathf.FloorToInt(expEachLvl[i - 1] * 1.05f);
        }
    }

    public void GainExp(int gainedExp)
    {
        expCur += gainedExp;

        if (levelCur < levelMax && expCur > expEachLvl[levelCur]) 
        {
            expCur -= expEachLvl[levelCur];
            levelCur++;

            // Increase stats here //
        }

        if (levelCur >= levelMax) 
        {
            levelCur = levelMax;
            expCur = 0;
        }
    }
}
