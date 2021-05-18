using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    float rayLength = 100;

    [SerializeField]
    LayerMask layerMask;
    public int scoreNum;
    public ParticleSystem death;

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.G) || OVRInput.Get(OVRInput.RawButton.RIndexTrigger))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, rayLength, layerMask))
            {
                
                deathFunction();
            }
        }
    }
    
   public void deathFunction()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        scoreNum += 1;
        if (Physics.Raycast(ray, out hit, rayLength, layerMask))
        {
            
            death.transform.position = hit.transform.position;
            death.Play();
            Destroy(hit.transform.gameObject, .1f);
            
        }
    }
}
