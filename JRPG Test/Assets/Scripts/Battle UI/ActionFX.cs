using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionFX : MonoBehaviour
{
    public float fxDuration;
    // public int sfxIndex;

    // Start is called before the first frame update
    void Start()
    {
        // play sound effect
    }

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject, fxDuration);
    }
}
