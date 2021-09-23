using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.Clear();
            Console.WriteLine("1. Addition.");
            Console.WriteLine("2. Rotations matris.");
            Console.WriteLine("3. Rotations matris med multiplikation.");
            Console.WriteLine("4. Multiplikation matris");
            Console.WriteLine("1-4");
            Console.ForegroundColor = ConsoleColor.Green;
            string v1 = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            //addition---------
            if (v1 == "1")
            {
                Console.Clear();
                Console.WriteLine("A. ");
                Console.WriteLine("Skriv in tal 1,2,3,4 (2x2)");
                Console.ForegroundColor = ConsoleColor.Green;
                string additionv1 = Console.ReadLine();
                string additionv2 = Console.ReadLine();
                string additionv3 = Console.ReadLine();
                string additionv4 = Console.ReadLine();
                float a00 = float.Parse(additionv1);
                float a01 = float.Parse(additionv2);
                float a10 = float.Parse(additionv3);
                float a11 = float.Parse(additionv4);

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("B. ");
                Console.WriteLine("Skriv in tal 1,2,3,4 (2x2)");
                Console.ForegroundColor = ConsoleColor.Green;
                string addition1 = Console.ReadLine();
                string addition2 = Console.ReadLine();
                string addition3 = Console.ReadLine();
                string addition4 = Console.ReadLine();
                float b00 = float.Parse(addition1);
                float b01 = float.Parse(addition2);
                float b10 = float.Parse(addition3);
                float b11 = float.Parse(addition4);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Svar:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(a00 + b00);
                Console.WriteLine(a01 + b01);
                Console.WriteLine(a10 + b10);
                Console.WriteLine(a11 + b11);
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                goto start;
            }
            //--Rot matris------------
            if (v1 == "2")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Skriv in tal (Cos sin, sin cos):");
                Console.ForegroundColor = ConsoleColor.Green;
                string question1 = Console.ReadLine();
                string question2 = Console.ReadLine();
                string question3 = Console.ReadLine();
                string question4 = Console.ReadLine();

                float a00 = float.Parse(question1);
                float a01 = float.Parse(question2);
                float a10 = float.Parse(question3);
                float a11 = float.Parse(question4);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Svar:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(Math.Cos(a00));
                Console.WriteLine(Math.Sin(a01));
                Console.WriteLine(Math.Sin(a10));
                Console.WriteLine(Math.Cos(a11));
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                goto start;
            }
            //----------Rot matris multi
            if (v1 == "3")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A.");
                Console.ForegroundColor = ConsoleColor.Green;
                string question1 = Console.ReadLine();
                string question2 = Console.ReadLine();
                string question3 = Console.ReadLine();
                string question4 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("B.");
                Console.ForegroundColor = ConsoleColor.Green;
                string questionb1 = Console.ReadLine();
                string questionb2 = Console.ReadLine();
                string questionb3 = Console.ReadLine();
                string questionb4 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                float a00 = float.Parse(question1);
                float a01 = float.Parse(question2);
                float a10 = float.Parse(question3);
                float a11 = float.Parse(question4);
                float b00 = float.Parse(questionb1);
                float b01 = float.Parse(questionb2);
                float b10 = float.Parse(questionb3);
                float b11 = float.Parse(questionb4);
                Console.WriteLine(Math.Cos(a00) * Math.Cos(b00) + (Math.Sin(a01) * Math.Sin(b10)));
                Console.WriteLine(Math.Cos(a00) * Math.Sin(b01) + (Math.Sin(a01) * Math.Cos(b11)));
                Console.WriteLine(Math.Sin(a10) * Math.Cos(b00) + (Math.Cos(a11) * Math.Sin(b10)));
                Console.WriteLine(Math.Sin(a01) * Math.Sin(b01) + (Math.Cos(a11) * Math.Cos(b11)));
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();

            }
            //Matris multi-----------------
            if (v1 == "4")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("A. ");
                Console.WriteLine("Skriv in tal 1,2,3,4 (2x2)");
                Console.ForegroundColor = ConsoleColor.Green;
                string multia1 = Console.ReadLine();
                float a00 = float.Parse(multia1);
                string multia2 = Console.ReadLine();
                float a01 = float.Parse(multia2);
                string multia3 = Console.ReadLine();
                float a10 = float.Parse(multia3);
                string multia4 = Console.ReadLine();
                float a11 = float.Parse(multia4);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("B. ");
                Console.WriteLine("Skriv in tal 1,2,3,4 (2x2)");
                Console.ForegroundColor = ConsoleColor.Green;
                string multib1 = Console.ReadLine();
                float b00 = float.Parse(multib1);
                string multib2 = Console.ReadLine();
                float b01 = float.Parse(multib2);
                string multib3 = Console.ReadLine();
                float b10 = float.Parse(multib3);
                string multib4 = Console.ReadLine();
                float b11 = float.Parse(multib4);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Svar:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(a00 * b00 + (a01 * b10));
                Console.WriteLine(a00 * b01 + (a01 * b11));
                Console.WriteLine(a10 * b00 + (a11 * b10));
                Console.WriteLine(a01 * b01 + (a11 * b11));
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadKey();
                goto start;
            }
            goto start;

        }
    }
}
