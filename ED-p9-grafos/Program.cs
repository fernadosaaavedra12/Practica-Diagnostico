class Program
{
    static void Main()
    {
        GrafoTransporte redFleet = new GrafoTransporte();

        // Agregamos puntos de la red
        redFleet.AgregarParada("Cochabamba");
        redFleet.AgregarParada("Quillacollo");
        redFleet.AgregarParada("Sacaba");

        // Creamos las conexiones de la flota
        redFleet.AgregarRuta("Cochabamba", "Quillacollo");
        redFleet.AgregarRuta("Cochabamba", "Sacaba");
        redFleet.AgregarRuta("Quillacollo", "Cochabamba");

        Console.WriteLine("--- Red de Rutas FleetControl ---");
        redFleet.MostrarRutas();
    }
}