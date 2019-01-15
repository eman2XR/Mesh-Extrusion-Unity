using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{

    void Update()
    {
        // Move the object upward in world space 1 unit/second.
        transform.position = transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time/2, 0.7f),  transform.position.z);
    }
}
