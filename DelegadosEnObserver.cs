using System;

// Delegado que define la firma del evento
public delegate void StockPriceChangedHandler(string stockName, double price);

// Clase que actúa como el "Sujeto"
public class Stock
{
    private string _name;
    private double _price;

    // Evento basado en el delegado
    public event StockPriceChangedHandler OnPriceChanged;

    public Stock(string name, double price)
    {
        _name = name;
        _price = price;
    }

    // Propiedad para cambiar el precio y notificar a los observadores
    public double Price
    {
        get { return _price; }
        set
        {
            if (_price != value)
            {
                _price = value;
                // Notificar a los suscriptores que el precio ha cambiado
                Notify();
            }
        }
    }

    private void Notify()
    {
        // Llamar al evento para notificar a los observadores
        if (OnPriceChanged != null)
        {
            OnPriceChanged(_name, _price);
        }
    }
}

// Clase que actúa como el "Observador"
public class StockObserver
{
    private string _observerName;

    public StockObserver(string name)
    {
        _observerName = name;
    }

    // Método que responde cuando el precio del stock cambia
    public void OnStockPriceChanged(string stockName, double price)
    {
        Console.WriteLine($"{_observerName} ha sido notificado: {stockName} ahora tiene un precio de {price}");
    }
}

// Clase principal para ejecutar el ejemplo
class Program
{
    static void Main()
    {
        // Crear el sujeto (una acción)
        Stock googleStock = new Stock("Google", 1500.00);

        // Crear observadores
        StockObserver observer1 = new StockObserver("Inversor 1");
        StockObserver observer2 = new StockObserver("Inversor 2");

        // Suscribirse al evento
        googleStock.OnPriceChanged += observer1.OnStockPriceChanged;
        googleStock.OnPriceChanged += observer2.OnStockPriceChanged;

        // Cambiar el precio y notificar a los observadores
        googleStock.Price = 1520.00;
        googleStock.Price = 1535.50;

        // Los observadores son notificados automáticamente
    }
}
