using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите простое уравнение из двух чисел");
                //Ввод строки
                string a = Console.ReadLine();
                string b = null;

                //Определение индекса знака между числами
                int index1 = a.IndexOf("*");
                int index2 = a.IndexOf("+");
                int index3 = a.IndexOf("/");
                int index4 = a.IndexOf("-");

                //ищем нужный знак и вставляем пробелы
                if (index1 > 0)
                {
                    a = a.Insert(index1, " ");
                    b = a.Insert(index1 + 2, " ");
                }
                else if (index2 > 0)
                {
                    a = a.Insert(index2, " ");
                    b = a.Insert(index2 + 2, " ");
                }
                else if (index3 > 0)
                {
                    a = a.Insert(index3, " ");
                    b = a.Insert(index3 + 2, " ");
                }
                else if (index4 > 0)
                {
                    a = a.Insert(index4, " ");
                    b = a.Insert(index4 + 2, " ");
                }
                else
                {
                    Console.WriteLine("Ошибка ввода");
                    return;
                }

                //подставляем полученную преобразованную строку и вычисляем
                String[] expressions = { b };
                String pattern = @"(\d+)\s+([-+*/])\s+(\d+)";
                foreach (var expression in expressions)
                    foreach (Match m in Regex.Matches(expression, pattern))
                    {
                        double value1 = Double.Parse(m.Groups[1].Value);
                        double value2 = Double.Parse(m.Groups[3].Value);
                        switch (m.Groups[2].Value)
                        {
                            case "+":
                                Console.WriteLine("{0} = {1}", m.Value, value1 + value2);
                                break;
                            case "-":
                                Console.WriteLine("{0} = {1}", m.Value, value1 - value2);
                                break;
                            case "*":
                                Console.WriteLine("{0} = {1}", m.Value, value1 * value2);
                                break;
                            case "/":
                                Console.WriteLine("{0} = {1:N2}", m.Value, value1 / value2);
                                break;
                            default:
                                Console.WriteLine("Ошибка");
                                break;
                        }
                        Console.WriteLine("Для выхода нажмите любую клавишу для нового ввода значений y");
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
}
