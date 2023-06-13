using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SearchService;


public class ChoiceButton : MonoBehaviour
{
    public FinalSwitch switchy;
    public GameObject buttonLeft;
    public GameObject buttonRight;
    public GameObject buttonMiddle;

    private void Update()
    {
        if (switchy.currentScene == 6)
        {
            buttonLeft.SetActive(true); buttonRight.SetActive(true); buttonMiddle.SetActive(false);   
        }
        else { if (switchy.currentScene != switchy.endScene) { buttonLeft.SetActive(false); buttonRight.SetActive(false); buttonMiddle.SetActive(true); } }

        if (switchy.currentScene == switchy.endScene + 1) { buttonLeft.SetActive(false); buttonRight.SetActive(false); buttonMiddle.SetActive(false); }
    }

    public void ChooseRoute1()
    {
        switchy.chosenRoute = 1;
        switchy.GoToImage(7);
    }

    public void ChooseRoute2()
    {
        switchy.chosenRoute = 2;
        switchy.GoToImage(12);
    }
}
