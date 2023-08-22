//Metodo Factory Method para el pedido.

// Interfaz 
interface IRepartidorFactory
{
    Repartidor CrearRepartidor();
    void EliminarRepartidor(Repartidor repartidor);
    void ModificarRepartidor(Repartidor repartidor);
}

// Clase base para los repartidores
abstract class Repartidor
{
    public int Id { get; set; }
    public abstract void EntregarPedido();
}

// Implementación concreta de un repartidor drone
class DroneRepartidor : Repartidor
{
    public override void EntregarPedido()
    {
        Console.WriteLine("El drone repartidor está entregando el pedido.");
    }
}

// Factory Method para la ABM de los drones (al momento del delivery)
// Se asume que el sistema para seleccionar al repartidor normal ya existe 
// y este se añade sin modificar el anterior

class DroneRepartidorFactory : IRepartidorFactory
{
    private List<Repartidor> repartidores = new List<Repartidor>();

    public Repartidor CrearRepartidor()
    {
        var droneRepartidor = new DroneRepartidor;
        repartidores.Add(droneRepartidor);
        return droneRepartidor;
    }

    public void EliminarRepartidor(Repartidor repartidor)
    {
        Console.WriteLine("Se ha desasignado el delivery con drone");
    }

    public void ModificarRepartidor(Repartidor repartidor)
    {
        Console.WriteLine("Se ha modificado el lugar de entrega");
    }
}



