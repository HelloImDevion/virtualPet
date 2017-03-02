using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("eat = 1");
            list.Add("fly = 2");
            list.Add("sleep = 3");
            list.Add("train = 4");
            list.Add("play = 5");

            foreach (string currentVal in list)
            {
                Console.WriteLine(currentVal);
            }

            {
                Console.WriteLine("Insert your needs: ");
                string userInPut = Console.ReadLine();
            }
        }
    }
}
