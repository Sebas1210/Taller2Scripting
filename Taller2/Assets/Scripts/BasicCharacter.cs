using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicCharacter : CharacterComponent
{
    public override void PerformAction()
    {
        Debug.Log("El personaje realiza una acción básica.");
    }
}
