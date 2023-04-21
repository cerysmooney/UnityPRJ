using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HoverObject : MonoBehaviour
{
  
 
    // Update is called once per frame
    public GameObject Inspection;
    public InspectionObject inspectionObj;
    public int index;
    void Update()
    {
    Ray ray = Camera.main.GetComponent<Camera>().ScreenPointToRay(Input.mousePosition);
    RaycastHit hit;
    if(GetComponent<Collider>().Raycast(ray, out hit, 20f)) 
    {
        
        print("hover on" + gameObject.name); 
        SceneManager.LoadScene("AbortionImage", LoadSceneMode.Single);
        if(Input.GetMouseButtonDown(0))
        {
            Inspection.SetActive(true);
        }
    }
    }
}
