using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
//GameObject player;

// void Start() 
// {
//    player =  GameObject.FindGameObjectWithTag("Player");
//    Debug.Log(player.name);
// }

 public void MoveToScene()
 {
   Debug.Log("clicked exit");
//   SavePosition.setPosition(player.transform.position, player.transform.rotation);
   SceneManager.LoadScene("Sms2Prj");

    
 }

   
}
