using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList stugrades = new ArrayList();
            stugrades = new ArrayList() { 85, 92, 78, 95, 88 };

            Console.WriteLine("grades: ");
            foreach (var grade in stugrades)
            {
                Console.WriteLine(grade);
            }
            int sum = 0;
            foreach(var grade in stugrades)
            {
                sum += (int)grade;

            }
            Console.WriteLine($"sum of grades: {sum}");

            stugrades.Add(90);

            Console.WriteLine("updated grades after added 90: ");
            foreach(var grade in stugrades)
            {
                Console.WriteLine(grade);
            }

            stugrades.Remove(78);

            Console.WriteLine("updated grades after removed 78: ");
            foreach (var grade in stugrades)
            {
                Console.WriteLine(grade);
            }

            int indexof95 = stugrades.IndexOf(95);

            if (indexof95 != -1)
            {
                stugrades[indexof95] = 96;

                Console.WriteLine("updated grades: ");
                foreach (var grade in stugrades)
                {
                    Console.WriteLine(grade);
                }

            }
            else
            {
                Console.WriteLine("grade 95 not found.");
            }


            Console.ReadKey();
        }
    }
}
