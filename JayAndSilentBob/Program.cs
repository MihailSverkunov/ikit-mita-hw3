using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace JayAndSilentBob
{
    class Program
    {
        static void Main(string[] args)
        {
            Jay jay = new Jay();
            SilentBob silentBob = new SilentBob();
            Numbertron numbertron = new Numbertron();

            numbertron.NewNumber += jay.FetchNewNuber;
            numbertron.NewNumber += silentBob.FetchNewNuber;

            int count = 0;
            while(count < 1)
            {
                try
                {
                    Console.WriteLine("Сколько чисел нужно сгенерировать?");
                    count = Convert.ToInt32(Console.ReadLine());
                    if (count < 1) Console.WriteLine("Число должно быть больше 0!\n");
                }
                catch(FormatException)
                {
                    Console.WriteLine("Введите число!\n");
                }
                catch(OverflowException)
                {
                    Console.WriteLine("Это слишком большое число!\n");
                }
            }

            Random r = new Random();

            for (int i = 0; i < count; i++)
            {
                numbertron.GenerateNumber(r);
            }

            if (jay.Score < silentBob.Score) Console.WriteLine("Победил Джей!");
            else
            {
                if (jay.Score > silentBob.Score) Console.WriteLine("Победил Молчаливый Боб!");
                else
                {
                    Console.WriteLine("Ничья!");
                }
            }
            Console.WriteLine(jay.Score + " " + silentBob.Score);


            Console.ReadLine();
        }
    }
}
