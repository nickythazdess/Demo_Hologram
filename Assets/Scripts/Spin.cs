using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField]
    private char axis;
    [SerializeField]
    private float angularVelocity;

    // Update is called once per frame
    void Update()
    {
        //rotates 50 degrees per second around z axis
        float angle = angularVelocity*Time.deltaTime;
        switch (axis) {
            case 'x': transform.Rotate (angle, 0, 0); break;
            case 'y': transform.Rotate (0, angle, 0); break;
            case 'z': transform.Rotate (0, 0, angle); break;
        }
            
    }
}
