using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoverSBES : MonoBehaviour
{
    private GameObject player;
    public GameObject Inspection;
    public InspectionObject inspectionObj;
    public int index;

public string sceneName;

void Start() 
{
   player =  GameObject.FindGameObjectWithTag("Player");
  
}

    void Update()
    {
    Ray ray = Camera.main.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    if(GetComponent<Collider>().Raycast(ray, out hit, 4.5f)) 
    {
      

      
      
       SavePosition.setPosition(player.transform.position, player.transform.rotation);
       
        Debug.Log(player); 
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        if(Input.GetMouseButtonDown(0))
        {
            Inspection.SetActive(true);
        }
        
    }


    }
}