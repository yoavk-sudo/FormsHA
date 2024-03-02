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
            var l = new ObservableLimitedList(ContainsS);
            l.OnListChange += PrintNewItem;
            l.TryAdd("Yoav");
            l.TryAdd("Iris");
            l.TryAdd("Daniel");
            l.TryAdd("Ido");
            l.TryAdd("Sapir");
            l.TryAdd("Ester");
            l.TryAdd("Dor");
            l.TryAdd("Noga");
            l.TryAdd("John");
            l.TryAdd("Max");
            l.PrintAll();

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
