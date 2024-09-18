using UnityEngine;

public class Observer : MonoBehaviour
{
    // Referencia al Subject
    public Subject subject;

    private void OnEnable()
    {
        // Suscribirse al evento cuando el objeto se activa
        subject.OnStateChanged += OnStateChanged;
    }

    private void OnDisable()
    {
        // Desuscribirse del evento cuando el objeto se desactiva
        subject.OnStateChanged -= OnStateChanged;
    }

    // Método que se ejecutará cuando se notifiquen los cambios
    private void OnStateChanged()
    {
        Debug.Log($"{name} ha sido notificado del cambio de estado a: {subject.State}");
    }
}
