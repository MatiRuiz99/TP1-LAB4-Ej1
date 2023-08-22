// Interfaz Observer
public interface IObserver
{
    void Update(string message);
}

// Clase que representa al cliente (simplificada para el ejemplo)
public class Customer : IObserver
{
    private string name;

    public Customer(string name)
    {
        this.name = name;
    }
    //Mediante el update se le notificará al cliente el estado de su pedido
    public void Update(string message)
    {
        Console.WriteLine($"{name}, Tenemos una actualizacion sobre tu pedido: {message}");
    }
}

// Clase observada
// En este ejemplo, podemos agregar multiples observers si el drone lleva multiples pedidos
public class Order
{
    private string status;
    private List<IObserver> observers = new List<IObserver>();

    public string Status
    {
        get { return status; }
        set
        {
            status = value;
            NotifyObservers($"Estado del pedido: {status}");
        }
    }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }
    //Las notificaciones en caso de llevar multiples pedidos podrian ser sobre la posición de su pedido
    //O la ubicación del drone 
    private void NotifyObservers(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }
}


