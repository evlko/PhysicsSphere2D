using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeState : MonoBehaviour
{
    public Sprite[] simStatus;
    public Image buttonSprite;
    public SystemChecker system;
    
    // Function to cpause or resume the simulation
    public void ChangeSimStatus(){
        system.simPlaying = !system.simPlaying;
        Time.timeScale = 1 - Time.timeScale;
        int indexSprite = (int) Time.timeScale;
        buttonSprite.sprite = simStatus[1 - indexSprite];
    }
}
