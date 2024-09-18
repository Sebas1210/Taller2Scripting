using System.IO;
using UnityEngine;

public class Logger
{
    private static Logger instance;
    private string filePath;

    // Constructor privado para evitar la creaci�n directa de instancias
    private Logger()
    {
        filePath = Application.persistentDataPath + "/log.txt";
    }

    // M�todo para obtener la �nica instancia del Singleton
    public static Logger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Logger();
            }
            return instance;
        }
    }

    // M�todo para registrar mensajes en el archivo
    public void Log(string message)
    {
        using (StreamWriter writer = new StreamWriter(filePath, true))
        {
            writer.WriteLine($"{System.DateTime.Now}: {message}");
        }
        Debug.Log($"Log registrado: {message}");
    }
}

// Ejemplo de uso en otro script
public class LoggerExample : MonoBehaviour
{
    void Start()
    {
        Logger.Instance.Log("Juego iniciado.");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Logger.Instance.Log("Se presion� la tecla Espacio.");
        }
    }
}
