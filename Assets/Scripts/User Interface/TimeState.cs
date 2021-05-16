using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeState : MonoBehaviour
{
    public Sprite[] simStatus;
    public Image buttonSprite;
    public SystemChecker system;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSimStatus(){
        if (system.simPlaying){
            system.simPlaying = false;
            Time.timeScale = 0f;
            buttonSprite.sprite = simStatus[1];
        }
        else{
            system.simPlaying = true;
            Time.timeScale = 1f;
            buttonSprite.sprite = simStatus[0];
        }
    }
}
