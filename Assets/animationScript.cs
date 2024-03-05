using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public class animationScript : MonoBehaviour
{
    [SerializeField] private AnimationCurve animationCurve;
    private float cuurrentTime;
    private float totalTime;

    void Start()
    {
        totalTime = animationCurve.keys[animationCurve.keys.Length - 1].time;
    }

    void FixedUpdate()
    {
        gameObject.transform.position = new Vector3(transform.position.x,
            animationCurve.Evaluate(cuurrentTime), transform.position.z);
        cuurrentTime += Time.fixedDeltaTime;
    }
}
