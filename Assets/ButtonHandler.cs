using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonHandler : MonoBehaviour
{

    private bool state = false;
    GameObject keyboard;
    GameObject keyboard2;

    public void Start()
    {
        keyboard = GameObject.Find("keyboard");
        keyboard2 = GameObject.Find("Cube");
        keyboard2.SetActive(false);
    }

    public void SetText(string text)
    {
        keyboard.SetActive(state);
        keyboard2.SetActive(!state);
        state = !state;
    }


}
