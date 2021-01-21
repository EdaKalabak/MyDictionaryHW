using System;

namespace MyDictionaryHW
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> words = new MyDictionary<string, int>();
            words.Add("Apple", 5);
            words.Add("Grapes", 6);
            words.Add("Carrot", 6);
            words.Add("Homework", 8);

            foreach (var key in words.Keys)
            {
                Console.WriteLine("Word:" + key);
            }

            foreach (var value in words.Values)
            {
                Console.WriteLine("The number of letters :" + value);
            }
        }
    }
}
