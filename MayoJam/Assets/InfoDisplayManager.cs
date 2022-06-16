using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoDisplayManager : MonoBehaviour
{
    public Camera cam;
    public ENEMYInfo enemyInfo;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                // the object identified by hit.transform was clicked
                // do whatever you want
            }
        }
    }
}
