using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
    private void OnGUI()
    {
        if(GUI.Button(new Rect(0,0,100,50),"Lock Cursor"))
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        if(GUI.Button(new Rect(125, 0,100,50), "Confine Cursor"))
        {
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
}
