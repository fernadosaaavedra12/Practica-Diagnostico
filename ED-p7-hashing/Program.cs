class Program
{
    static void Main()
    {
        TablaHashBuses fleetHash = new TablaHashBuses(10);

        // Insertar datos reales (puedes coordinar estos IDs con Moises o RoRo)
        fleetHash.Insertar("345-LPZ", new Bus("345-LPZ", "Fernando", "Cochabamba - Santa Cruz"));
        fleetHash.Insertar("789-CBBA", new Bus("789-CBBA", "Rommel", "Cochabamba - La Paz"));

        // Buscar un bus
        Console.WriteLine("Ingrese la placa a buscar:");
        string buscarPlaca = Console.ReadLine();
        
        Bus encontrado = fleetHash.Buscar(buscarPlaca);

        if (encontrado != null)
        {
            Console.WriteLine($"Bus localizado. Chofer: {encontrado.Chofer}, Ruta: {encontrado.Ruta}");
        }
        else
        {
            Console.WriteLine("Vehículo no encontrado en el sistema FleetControl.");
        }
    }
}