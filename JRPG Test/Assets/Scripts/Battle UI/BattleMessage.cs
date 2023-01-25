using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    This class represents text that will appear on screen, giving valuable information to the player.
    It has a set duration of time in which it will be on screen before it is set to inactive.
*/

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
