using EX_Final_Estructuras.Services;

namespace EX_Final_Estructuras
{
    class Program
    {
        static void Main(string[] args)
        {
            NetworkSimulator simulator = new NetworkSimulator();

            simulator.Simulate();
        }
    }
}