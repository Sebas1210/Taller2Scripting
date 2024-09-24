using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CharacterDecorator : CharacterComponent
{
    protected CharacterComponent _character;

    public CharacterDecorator(CharacterComponent character)
    {
        _character = character;
    }

    public override void PerformAction()
    {
        _character.PerformAction();
    }
}
