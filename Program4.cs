using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLight3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string clientName = "Ivanov";
            string clientSurname = "Ivan";
            Console.WriteLine("Имя клиента до перестановки: " +  clientName);
            Console.WriteLine("Фамилия клиента до перестановки: " + clientSurname);
            Console.WriteLine("Перестановка...");
            string bufferVariablePermutation = clientName;
            clientName = clientSurname;
            clientSurname = bufferVariablePermutation;
            Console.WriteLine("Имя клиента после перестановки: " + clientName);
            Console.WriteLine("Фамилия клиента после перестановки: " + clientSurname);
            Console.ReadKey();
        }
    }
}
