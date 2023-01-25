using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
    This class represents numbers that will appear on screen, showing how much damage an attack of effect caused.
    It has a "placementJitter" parameter which will allow for variance in where the damage value is placed.
*/

public class DamageValue : MonoBehaviour // HitValue
{
    public Text hitValueText;
    public float numDuration = 1.0f, moveSpeed = 1.0f, placementJitter = 0.5f;

    void Update()
    {
        Destroy(gameObject, numDuration);
        transform.position += new Vector3(Random.Range(-placementJitter, placementJitter), Random.Range(-placementJitter, placementJitter), 0f);
    }
}
