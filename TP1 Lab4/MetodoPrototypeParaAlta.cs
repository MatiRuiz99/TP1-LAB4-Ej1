
//Metodo Prototype para la creación nuevos Drones con el mismo modelo
//Con el método Prototype se puede crear multiples Drones con las mismas caracteristicas pero distinto ID
//Esto puede ser muy util si solo se utiliza 1 modelo de drone
//Ejemplo básico con Alta y una Baja logica

// Interfaz 
public interface IPrototype
{
    IPrototype Clone();
    void MostrarInformación();
    void MarcarComoNoDisponible();
}

// Clase concreta que implementa el metodo Prototype
// El dron podria tener una descripción, limite de carga, etc
public class DronRepartidor : IPrototype
{
    public Guid DronID { get; private set; }
    public int NumeroSerie { get; private set; }
    public string Modelo { get; private set; }
    public bool Disponible { get; private set; }

    public DronRepartidor(int numeroSerie, string modelo)
    {
        DronID = Guid.NewGuid(); // Genera un ID único
        NumeroSerie = numeroSerie;
        Modelo = modelo;
        Disponible = true;
    }
    //Clone copia el Modelo Base.
    public IPrototype Clone()
    {
        return new DronRepartidor(NumeroSerie, Modelo);
    }

    public void MostrarInformación()
    {
        Console.WriteLine($"DronID: {DronID} - Numero de Serie: {NumeroSerie} - Modelo: {Modelo} - Disponible: {Disponible}");
    }

    public void MarcarComoNoDisponible()
    {
        Disponible = false;
    }
}
//Ejemplo del funcionamiento

// Crea el dron inicial
//IPrototype prototipoDron = new DronRepartidor(1, "MK30");

// Clona el dron para crear nuevos drones
//IPrototype nuevoDron1 = prototipoDron.Clone();
//IPrototype nuevoDron2 = prototipoDron.Clone();

// Marca un dron como no disponible (baja lógica)
//nuevoDron1.MarcarComoNoDisponible();

// Muestra info
// nuevoDron1.MostrarInformación();

  
