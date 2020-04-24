using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeypadPanel : MonoBehaviour
{
    [SerializeField]
    Text KeypadText;

    string KeypadValue = "";

    
    // Update is called once per frame
    void Update()
    {
        KeypadText.text = KeypadValue;

        if(KeypadValue == "1111")
        {
            TriggerEnterKeypad.DoorIsOpen = true;
        }
        if(KeypadValue == "2222")
        {
            TriggerEnterKeypad.Door2IsOpen = true;
        }
        if(KeypadValue == "3333")
        {
            TriggerEnterKeypad.Door3IsOpen = true;
        }
        if(KeypadValue == "4444")
        {
            TriggerEnterKeypad.Door4IsOpen = true;
        }


        if (KeypadValue.Length >= 4)
        {
            KeypadValue = "";
        }

    }
    public void AddDigit(string digit)
    {
        KeypadValue += digit;
    }
}
