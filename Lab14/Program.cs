using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Алиса");
            cat.ShowInfo();
            Dog dog = new Dog("Арчи");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
}
