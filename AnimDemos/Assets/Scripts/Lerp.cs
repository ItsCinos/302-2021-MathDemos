using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{

    public GameObject startObject;
    public GameObject endObject;

    [Range(0, 1)] public float percent = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void DoTheLerp()
    {
        transform.position = Vector3.Lerp(
            startObject.transform.position, 
            endObject.transform.position,
            percent
            );
    }

    private void OnValidate()
    {
        DoTheLerp;
    }
}
