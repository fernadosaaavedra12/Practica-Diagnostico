namespace EX_Final_Estructuras.Models
{
    public class HistoryNode
    {
        public string IP { get; set; }

        public HistoryNode Next { get; set; }
        public HistoryNode Previous { get; set; }

        public HistoryNode(string ip)
        {
            IP = ip;
            Next = null;
            Previous = null;
        }
    }
}