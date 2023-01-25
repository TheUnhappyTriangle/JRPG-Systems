using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
    This class represents the game over screen when/if the player loses.
    The player will have the option to either load the last save or go to the main menu.
    Honestly as I write this thinking about just cutting the option to go to the main menu entirely.
    Perhaps it can be just a quick sappy song and visual and just put the player back to their last save?
    But maybe the option is good even if it is slower..?
*/

public class GameOverScreen : MonoBehaviour
{
    public string mainMenuScene, loadGameScene;

    // Start is called before the first frame update
    void Start()
    {
        // play game over music
    }

    public void QuitToMainMenu()
    {
        // destroy game manager
        // destroy player controller
        // destroy GameMenu
        // destroy AudioManager
        // destroy battlemanager
        // load menu scene
    }

    public void LoadLastSave()
    {
        // destroy Game Manager
        // destroy player controller
        // destroy gamemenu
          // destroy battle manager
        // load last scene
    }
}
