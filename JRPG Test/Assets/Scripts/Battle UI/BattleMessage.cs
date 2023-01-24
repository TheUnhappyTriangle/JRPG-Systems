using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleMessage : MonoBehaviour
{
    public float messageDuration, messageCountdown;

    // Update is called once per frame
    void Update()
    {
        messageCountdown -= Time.deltaTime;
        if(messageCountdown <= 0.0f)
        {
            gameObject.SetActive(false);
        }
    }

    public void SendMessage()
    {
        gameObject.SetActive(true);
        messageCountdown = messageDuration;
    }
}
