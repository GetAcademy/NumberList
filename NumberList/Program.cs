using System;

namespace NumberList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>();

            while (true)
            {
                Console.Write("Skriv inn et navn: ");
                var name = Console.ReadLine();
                if (name =="") return;
                list.Add(name);
                list.Show();
            }
        }

        static void MainInt(string[] args)
        {
            var list = new List<int>();
            var list2 = new List<int>();

            while (true)
            {
                Console.Write("Skriv inn et tall: ");
                var numberStr = Console.ReadLine();
                var number = Convert.ToInt32(numberStr);
                if (number == 0) return;
                var correctList = number > 100 ? list : list2;
                correctList.Add(number);
                correctList.Show();
            }
        }
    }
}
