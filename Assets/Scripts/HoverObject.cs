using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    if(GetComponent<Collider>().Raycast(ray, out hit, 100f)) 
    {
        print("hover on" + gameObject.name); 
        if(Input.GetMouseButtonDown(0))
        {
            Inspection.SetActive(true);
        }
    }
    }
}
