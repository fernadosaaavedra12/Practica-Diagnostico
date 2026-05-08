namespace EX_Final_Estructuras.Models
{
    public class Packet
    {
        public int Id { get; set; }
        public string SourceIP { get; set; }
        public string DestinationIP { get; set; }
        public int PayloadSize { get; set; }

        public Packet(int id, string sourceIP, string destinationIP, int payloadSize)
        {
            Id = id;
            SourceIP = sourceIP;
            DestinationIP = destinationIP;
            PayloadSize = payloadSize;
        }

        public override string ToString()
        {
            return $"Packet #{Id} | From: {SourceIP} -> To: {DestinationIP} | Payload: {PayloadSize} bytes";
        }
    }
}