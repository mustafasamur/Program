using MyDictionaryIntro;
using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> padisahlar = new MyDictionary<int, string>();

            padisahlar.Add(1, "Osman Gazi");
            padisahlar.Add(2, "Orhan Gazi");
            padisahlar.Add(3, "I. Murat");
            padisahlar.Add(4, "I. Bayezid – Yıldırım Bayezid");
            padisahlar.Add(5, "I. Mehmed ");
            padisahlar.Add(6, "II. Murad ");
            padisahlar.Add(7, " Fatih Sultan Mehmed ");

            for (int i = 0; i < padisahlar.Key.Length; i++)
            {
                int item = padisahlar.Key[i];
                Console.WriteLine(padisahlar.Value.GetValue(i));
            }
        



        }
    }
}
