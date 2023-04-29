using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BacktoMain : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.None;
       
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        if(SavePosition.positionSet)
        {
            player.transform.position = SavePosition.position;
            player.transform.rotation = SavePosition.rotation;
        }

    }

    // Update is called once per frame
   
}
