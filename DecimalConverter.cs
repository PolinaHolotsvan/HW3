using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class DecimalConverter
    {
        public decimal Convert(string phrase)
        {
            decimal result=0;
            bool converted = false;
            Console.WriteLine($"Введiть {phrase}");
            do
            {
                string line = Console.ReadLine();
                if (line == "")
                {
                    Console.WriteLine("Ви не ввели значення, введiть знову!");
                }
                else
                {
                    try
                    {
                        result = decimal.Parse(line);
                        if (result <= 0)
                        {
                            Console.WriteLine("Ви ввели недодатнє значення, введiть знову!");
                        }
                        else
                        {
                            converted = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Ви неправильно ввели значення, введiть знову!");
                    }
                }
            }
            while (!converted);
            
            return result;
        }
    }
}
