using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldDecorator : CharacterDecorator
{
    public ShieldDecorator(CharacterComponent character) : base(character) {}

    public override void PerformAction()
    {
        base.PerformAction();
        Debug.Log("El personaje ahora tiene un escudo.");
    }
}
