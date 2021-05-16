using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoPanel : MonoBehaviour
{
    public Transform informationPanel;
    public Text objectNameText;
    public Text massText;
    public Text vspeedText;
    public Text hspeedText;
    public Sprite[] statusLine;
    public Image statusLineImage;
    Sphere sphere;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivatePanel(bool status, Sphere sphereClicked){
        informationPanel.gameObject.SetActive(status);
        sphere = sphereClicked;
        ShowInfo();
    }

    public void ShowInfo(){
        objectNameText.text = "Object: " + sphere.gameObject.name;
        massText.text = "Mass: " + sphere.mass.ToString();
        vspeedText.text = "VSpeed: " + sphere.vspeed.ToString();
        hspeedText.text = "HSpeed: " + sphere.hspeed.ToString();
    }

    public void ChangeMass(int value){
        sphere.mass += value;
        ShowInfo();
    }

    public void ChangeHSpeed(int value){
        sphere.hspeed += value;
        ShowInfo();
        sphere.DrawSpeed();
    }

    public void ChangeVspeed(int value){
        sphere.vspeed += value;
        ShowInfo();
        sphere.DrawSpeed();
    }

    public void ChangeLineStatus(){
        if (sphere.showLine == true){
            statusLineImage.sprite = statusLine[1];
            sphere.DestroySpeed();
            sphere.showLine = false;
        }
        else {
            statusLineImage.sprite = statusLine[0];
            sphere.showLine = true;
        }
    }
}
