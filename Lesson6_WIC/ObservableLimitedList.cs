using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_WIC
{
    internal class ObservableLimitedList
    {
        private List<string> _list = new();
        public ObservableLimitedList(Predicate<string> condition)
        {
            _stringCondition = condition;
        }
        public void TryAdd(string s)
        {
            if (_stringCondition.Invoke(s))
            {
                _list.Add(s);
                OnListChange.Invoke(s);
            }
        }
        public void PrintAll()
        {
            foreach (var str in _list)
            {
                Console.WriteLine(str);
            }
        }
        public static int operator +(ObservableLimitedList a, int b)
        {
            return 0;
        }
        public event Action<string> OnListChange;
        private Predicate<string> _stringCondition;
    }
}
