using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContactScript : MonoBehaviour
{
    MeshRenderer mR;
    // Start is called before the first frame update
    void Start()
    {
        mR = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            mR.material.color = Color.blue;
        }
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            mR.material.color = Color.grey;
        }
        if (OVRInput.GetDown(OVRInput.Button.DpadUp))
        {
            mR.material.color = Color.yellow;
        }
        if (OVRInput.GetDown(OVRInput.Button.DpadDown))
        {
            mR.material.color = Color.cyan;
        }
        if (OVRInput.GetDown(OVRInput.Button.DpadLeft))
        {
            mR.material.color = Color.red;
        }
        if (OVRInput.GetDown(OVRInput.Button.DpadRight))
        {
            mR.material.color = Color.red;
        }
    }
}
