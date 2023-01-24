using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageValue : MonoBehaviour
{
    public Text hitValueText;
    public float numDuration = 1.0f, moveSpeed = 1.0f, placementJitter = 0.5f;

    void Update()
    {
        Destroy(gameObject, numDuration);
        transform.position += new Vector3(Random.Range(-placementJitter, placementJitter), Random.Range(-placementJitter, placementJitter), 0f);
    }
}
