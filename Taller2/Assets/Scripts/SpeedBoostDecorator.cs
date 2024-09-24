using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostDecorator : CharacterDecorator
{
    public SpeedBoostDecorator(CharacterComponent character) : base(character) {}

    public override void PerformAction()
    {
        base.PerformAction();
        Debug.Log("El personaje ahora se mueve más rápido.");
    }
}
