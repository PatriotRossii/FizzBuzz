using System;

namespace FizzBuzz {
    class Program {
        public static void Main(string[] args) {
            Console.Write("Введите число, до которого необходимо вести счет: ");
            String line = Console.ReadLine();

            int border = 0;
            int.TryParse(line, out border);

            for(int i = 1; i <= border; ++i)
            {
                if(i % 3 == 0)
                {
                    Console.Write("Fizz");
                } if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                if (!(i % 5 == 0) && !(i % 3 == 0))
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
        }
    }
}