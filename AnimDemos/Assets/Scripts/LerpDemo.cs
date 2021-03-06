using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpDemo : MonoBehaviour
{

    public GameObject startObject;
    public GameObject endObject;

    [Range(-1, 2)] public float percent = 0;

    public float animationLength = 2;
    private float animationPlayheadTime = 0;
    private bool isAnimPlaying = false;

    public AnimationCurve animationCurve;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isAnimPlaying) { 
            animationPlayheadTime += Time.deltaTime;
            percent = animationPlayheadTime / animationLength;
            percent = Mathf.Clamp(percent, 0, 1);
            //percent = percent * percent * (3 - 2 * percent); //ease in-out
            float p = animationCurve.Evaluate(percent);
            
            DoTheLerp(p);
            if (percent >= 1) isAnimPlaying = false;
        }
    }

    private void DoTheLerp(float p)
    {
        transform.position = AnimMath.Lerp(
            startObject.transform.position,
            endObject.transform.position,
            p
            );
    }

    public void PlayTweenAnim()
    {
        isAnimPlaying = true;
        animationPlayheadTime = 0;
    }

    private void OnValidate()
    {
        DoTheLerp(percent);
    }
}
