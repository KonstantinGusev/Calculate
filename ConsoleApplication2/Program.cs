using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
    
    /// <summary>
    /// Программа для считывания выражения строки и вычисления
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            var s = "3^4+21";
            double r = Parse(s);
            Console.WriteLine(r);
            Console.ReadLine();
        }

        // Парсинг строки 
        // Метод проверяет приоритетность + и -. По факту выполняется самым последним
        static int Parse(string s)
        {
            int index = 0;
            var v = DivMode(s, ref index);
            while (index < s.Length)
            {
                switch (s[index])
                {
                    case '+':
                        index++;
                        v += DivMode(s, ref index);
                        return v;
                    case '-':
                        index++;
                        v -= DivMode(s, ref index);
                        return v;

                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }

            return v;
        }

        // Метод проверяет приоритетность * и /. Выполняется вторым
        static int DivMode(string s,ref int index)
        {
            
            var v = Xor(s, ref index);
            while (index < s.Length)
            {
                switch (s[index])
                {
                    case '*':
                        index++;
                        v *= Xor(s, ref index);
                        return v;
                    case '/':
                        index++;
                        v /= Xor(s, ref index);
                        return v;

                    default:
                        
                        return v;
                }
            }

            return v;
        }

        //Метод проверяет есть ли выражение которое нужно возвести в степень
        static int Xor(string s, ref int index)
        {
            
            var v = GetNumber(s, ref index);
            while (index < s.Length)
            {
                switch (s[index])
                {
                    case '^':
                       double z1 = v;
                        index++;
                        v = GetNumber(s, ref index);
                        double x = v;
                        double xor = Math.Pow(z1,x);
                        v = (int)xor;
                        
                        return v;


                    default:
                        
                        return v;
                }
            }

            return v;
        }

        // Метод отбирающий числа в строке
        static int GetNumber(string s, ref int index)
        {
            var tmp = "";
            foreach (var c in s.Substring(index))
            {
                if (!char.IsDigit(c))
                {
                    break;
                }

                index++;
                tmp += c;
            }

            return int.Parse(tmp);
        }      
    }
}