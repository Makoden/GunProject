using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    LineRenderer line;
    float rayLength = 10;

    [SerializeField]
    LayerMask layerMask;
   
    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) || OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, rayLength, layerMask))
            {
                line.startColor = Color.blue;
            }

            else
            {
                line.startColor = Color.grey;
            }
        }

        if (Input.GetKeyDown(KeyCode.G) || OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            line.startColor = Color.white;
        }

        line.SetPosition(0, transform.position);
        line.SetPosition(1, transform.position, transform.forward * rayLength);
           
    }
}
