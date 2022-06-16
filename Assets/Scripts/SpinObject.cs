using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObject : MonoBehaviour
{
    public Vector3 axis = Vector3.up;
    public float rate;
    public AnimationCurve curve;
    public GameObject obj;

    void Update()
    {
        transform.Rotate(0, 5, 0);
    }
}
