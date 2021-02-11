using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideTowards : MonoBehaviour
{
    public Transform target;

    private Camera cam;

    private void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }
    void Update()
    {
        
        //slides position towards target
        transform.position = AnimMath.Slide(transform.position, target.position, 0.01f);

        //ease camera rotation to look at target

        //get vector to target
        Vector3 vectorToTarget = target.position - cam.transform.position;

        //create desired rotation
        Quaternion targetRotation = Quaternion.LookRotation(vectorToTarget, Vector3.up);

        //set cam to ease toward target rotation
        cam.transform.rotation = AnimMath.Slide(cam.transform.rotation, targetRotation, .05f);


    }
}
