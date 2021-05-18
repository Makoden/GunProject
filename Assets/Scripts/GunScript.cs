﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{ 
    LineRenderer line;
    float rayLength = 100;

    [SerializeField]
    LayerMask layerMask;

    public Animator gunFireAnim;
    public ParticleSystem muzzFlash;

    // Start is called before the first frame update
    void Start()
    {
        line = GetComponent<LineRenderer>();
        gunFireAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) || OVRInput.GetDown(OVRInput.RawButton.RIndexTrigger))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            gunFireAnim.SetBool("TriggerDown", true);
            muzzFlash.Play();
            if (Physics.Raycast(ray, out hit, rayLength, layerMask))
            {
                line.startColor = Color.blue;
            }

            else
            {
                line.startColor = Color.grey;
            }
        }

        if (Input.GetKeyUp(KeyCode.G) || OVRInput.GetUp(OVRInput.RawButton.RIndexTrigger))
        {
            line.startColor = Color.white;
            gunFireAnim.SetBool("TriggerDown", false);
        }

        line.SetPosition(0, transform.position);
        line.SetPosition(1, transform.position + (transform.forward * rayLength));
    }
}
