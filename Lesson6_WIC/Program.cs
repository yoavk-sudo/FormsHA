namespace Lesson6_WIC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelegatesWIC();
        }

        private static void DelegatesWIC()
        {
            var listOfS = new ObservableLimitedList(ContainsS);
            listOfS.OnListChange += PrintNewItem;
            listOfS.TryAdd("Yoav");
            listOfS.TryAdd("Iris");
            listOfS.TryAdd("Daniel");
            listOfS.TryAdd("Ido");
            listOfS.TryAdd("Sapir");
            listOfS.TryAdd("Ester");
            listOfS.TryAdd("Dor");
            listOfS.TryAdd("Noga");
            listOfS.TryAdd("John");
            listOfS.TryAdd("Max");
            listOfS.PrintAll();
        
            bool ContainsS(string str)
            {
                return str.Contains('s') || str.Contains('S');
            }
            void PrintNewItem(string str)
            {
                Console.WriteLine("Item added was: " + str);
            }
        }
    }
}
