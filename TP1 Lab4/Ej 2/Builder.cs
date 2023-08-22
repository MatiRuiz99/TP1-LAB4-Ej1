


namespace TP1_Lab4.Ej_2
{
    // Producto
    class Car
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }

        public void Display()
        {
            Console.WriteLine($"Car model: {Model}, Engine: {Engine}, Transmission: {Transmission}");
        }
    }

    // Builder abstracto
    interface ICarBuilder
    {
        void BuildModel();
        void BuildEngine();
        void BuildTransmission();
        Car GetCar();
    }

    // Builder
    class SedanCarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public void BuildModel()
        {
            _car.Model = "Sedan";
        }

        public void BuildEngine()
        {
            _car.Engine = "4-cylinder";
        }

        public void BuildTransmission()
        {
            _car.Transmission = "Automatic";
        }

        public Car GetCar()
        {
            return _car;
        }
    }

    // Director
    class CarDirector
    {
        private ICarBuilder _builder;

        public CarDirector(ICarBuilder builder)
        {
            _builder = builder;
        }

        public void BuildCar()
        {
            _builder.BuildModel();
            _builder.BuildEngine();
            _builder.BuildTransmission();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ICarBuilder builder = new SedanCarBuilder();
            CarDirector director = new CarDirector(builder);

            director.BuildCar();
            Car car = builder.GetCar();

            car.Display();
        }
    }

}