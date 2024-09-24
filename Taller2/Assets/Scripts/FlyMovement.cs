using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyMovement : IMovementStrategy
{
    public void Move(Transform transform)
    {
        transform.Translate(Vector3.up * Time.deltaTime * 5);
    }
}