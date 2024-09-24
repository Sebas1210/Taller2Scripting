using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Character : MonoBehaviour
{
    // Para el Patrón Strategy
    private IMovementStrategy _movementStrategy;

    // Para el Patrón Decorator
    CharacterComponent baseCharacter;

    void Start()
    {
        // Establecer la estrategia inicial de movimiento (caminar)
        SetMovementStrategy(new WalkMovement());

        // Crear el personaje base para el decorador
        baseCharacter = gameObject.AddComponent<BasicCharacter>();
    }

    void Update()
    {
        // Actualizar la estrategia de movimiento (Patrón Strategy)
        if (_movementStrategy != null)
        {
            _movementStrategy.Move(transform);
        }

        // Cambiar de estrategia de movimiento con teclas
        if (Input.GetKeyDown(KeyCode.W))
        {
            SetMovementStrategy(new WalkMovement()); // Caminar
            Debug.Log("Cambiando a caminar.");
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            SetMovementStrategy(new FlyMovement()); // Volar
            Debug.Log("Cambiando a volar.");
        }

        // Decoradores para agregar habilidades al personaje (Patrón Decorator)
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Aplicar decorador de escudo
            baseCharacter = new ShieldDecorator(baseCharacter);
            baseCharacter.PerformAction();
            Debug.Log("El personaje ha obtenido un escudo.");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            // Aplicar decorador de aumento de velocidad
            baseCharacter = new SpeedBoostDecorator(baseCharacter);
            baseCharacter.PerformAction();
            Debug.Log("El personaje ahora tiene un aumento de velocidad.");
        }
    }

    // Método para cambiar la estrategia de movimiento
    public void SetMovementStrategy(IMovementStrategy movementStrategy)
    {
        _movementStrategy = movementStrategy;
    }
}
