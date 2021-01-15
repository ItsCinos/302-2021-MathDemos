using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerp : MonoBehaviour
{

    public GameObject startObject;
    public GameObject endObject;

    [Range(-1, 2)] public float percent = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = AnimMath.Lerp(
            startObject.transform.position, 
            endObject.transform.position,
            percent
            );
    }
}
