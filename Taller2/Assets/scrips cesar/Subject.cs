using System;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    // Evento para notificar a los observadores
    public event Action OnStateChanged;

    private string state;

    // Propiedad para cambiar el estado y notificar a los observadores
    public string State
    {
        get { return state; }
        set
        {
            state = value;
            NotifyObservers();
        }
    }

    // Método para notificar a los observadores
    private void NotifyObservers()
    {
        if (OnStateChanged != null)
        {
            OnStateChanged.Invoke();
        }
    }
}
