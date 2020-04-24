using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerEnterKeypad : MonoBehaviour
{
    [SerializeField]
    public GameObject KeypadUi, Door, Door2, Door3, Door4;

    public static bool DoorIsOpen = false;
    public static bool Door2IsOpen = false;
    public static bool Door3IsOpen = false;
    public static bool Door4IsOpen = false;


    private void Start()
    {
        Cursor.visible = true;
        Door.SetActive(true);
  
    }
    private void Update()
    {
        if (DoorIsOpen)
        {
            Door.SetActive(false);
            KeypadUi.SetActive(false);
        }
        if (Door2IsOpen)
        {
            Door2.SetActive(false);
            KeypadUi.SetActive(false);
        }
        if (Door3IsOpen)
        {
            Door3.SetActive(false);
            KeypadUi.SetActive(false);
        }
        if (Door4IsOpen)
        {
            Door4.SetActive(false);
            KeypadUi.SetActive(false);
        }

    }
    void OnTriggerEnter(Collider other)
    {

        KeypadUi.SetActive(true);
        
    }

     void OnTriggerExit(Collider other)
    {
        KeypadUi.SetActive(false);
    }
}
