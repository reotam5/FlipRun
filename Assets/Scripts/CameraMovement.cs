using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform agentTransform;
    void FixedUpdate()
    {
        var ypos = transform.position.y;
        var zpos = transform.position.z;
        transform.position = new UnityEngine.Vector3(agentTransform.position.x,ypos,zpos);

    }
}
