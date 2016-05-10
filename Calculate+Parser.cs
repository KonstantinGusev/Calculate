using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace ConsoleApplication129
{


    class Program
    {
        static void Main(string[] args)
        {
            var s = "12/0+43-23*65";
            double r = Parse(s);
            Console.WriteLine(r);
        }

        static int Parse(string s)
        {
            int index = 0;
            var v = GetNumber(s, ref index);
            while (index < s.Length)
            {
                switch (s[index])
                {
                    case '+':
                        index++;
                        v += GetNumber(s, ref index);
                        break;
                    case '-':
                        index++;
                        v -= GetNumber(s, ref index);
                        break;
                    case '/':
                        index++;
                        v = GetNumber(s, ref index);
                        if (v == 0)
                        {
                            Console.WriteLine("Ахтунг!!!Нельзя делить на 0!!!");
                            return 0;
                        }
                        else
                        {
                            v /= GetNumber(s, ref index);
                        }
                        break;
                    case '*':
                        index++;
                        v *= GetNumber(s, ref index);
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            }

            return v;
        }

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

