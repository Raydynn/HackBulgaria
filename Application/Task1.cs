using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Input starting point \"x\": ");
            string x = Console.ReadLine();
            int xValue = Int32.Parse(x);

            Console.WriteLine("Input starting point \"y\": ");
            string y = Console.ReadLine();
            int yValue = Int32.Parse(y);

            Console.WriteLine("Input string: ");
            string symbols = Console.ReadLine();

            bool symbolTrigger = true;

            for (int i = 0; i < symbols.Length; i++)
            {
                if (symbols[i] == '~')
                {
                    symbolTrigger = !symbolTrigger;
                    continue;
                }
                else
                {
                    if (symbolTrigger == true)
                    {
                        if (symbols[i] == '<')
                        {
                            xValue--;
                        }
                        else if (symbols[i] == '>')
                        {
                            xValue++;
                        }
                        else if (symbols[i] == '^')
                        {
                            yValue--;
                        }
                        else if (symbols[i] == 'v')
                        {
                            yValue++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else if (symbolTrigger == false)
                    {
                        if (symbols[i] == '<')
                        {
                            xValue++;
                        }
                        else if (symbols[i] == '>')
                        {
                            xValue--;
                        }
                        else if (symbols[i] == '^')
                        {
                            yValue++;
                        }
                        else if (symbols[i] == 'v')
                        {
                            yValue--;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            Console.WriteLine("({0}), ({1})", xValue, yValue);
        }
    }
}
