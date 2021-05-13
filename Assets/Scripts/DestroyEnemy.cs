using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    float rayLength = 100;

    [SerializeField]
    LayerMask layerMask;

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.G) || OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, rayLength, layerMask))
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
