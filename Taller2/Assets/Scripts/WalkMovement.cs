using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkMovement : IMovementStrategy
{
    public void Move(Transform transform)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 5);
    }
}