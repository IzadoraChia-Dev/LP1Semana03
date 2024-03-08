using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("write a sentence please:");
            string input1 = Console.ReadLine();
            Console.WriteLine("chose a character:");
            string input2 = Console.ReadLine();
            char cara = char.Parse(input2);

            string stringFinal = "";

            foreach (char a in input1)
            {
                if (a == cara)
                {
                    stringFinal += "X";
                }
                else
                {
                    stringFinal += a;
                }
            }

            Console.WriteLine(stringFinal);
            
        }
    }
}
    