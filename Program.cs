namespace Lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> L1 = new List<int> {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            List<int> L2 = new List<int> {11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            List<List<int>> Tudo = new List<List<int>> {L1, L2};
        }
    }
