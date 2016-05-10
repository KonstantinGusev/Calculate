using System;
using Microsoft.JScript;
using Microsoft.JScript.Vsa;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main()
        {
            ///пример работы такой
            while (true)
            {
                Console.Write("Введите уравнение: ");
                try
                {
                    var res = Eval.JScriptEvaluate(Console.ReadLine(), VsaEngine.CreateEngine());
                    Console.WriteLine("Ответ: " + res);
                }
                catch { Console.WriteLine("Ошибка"); }

                Console.WriteLine("Ввести еще нажать y, закончить вычисления любую клавишу");
                string c = Console.ReadLine();
                switch (c)

                {
                    case "y":
                        Console.Clear();
                        break;

                    default:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
