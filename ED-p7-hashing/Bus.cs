public class Bus
{
    public string Placa { get; set; }
    public string Chofer { get; set; }
    public string Ruta { get; set; }

    public Bus(string placa, string chofer, string ruta)
    {
        Placa = placa;
        Chofer = chofer;
        Ruta = ruta;
    }
}