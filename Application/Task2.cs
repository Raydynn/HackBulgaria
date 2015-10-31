using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input number of lines: ");
            string row = Console.ReadLine();
            int rowNum = Int32.Parse(row);

            Console.WriteLine("Input number of symbols on each line: ");
            string symbols = Console.ReadLine();
            int symbolsNum = Int32.Parse(symbols);

            List<string> lines = new List<string>();

            Console.WriteLine("Input lines: ");

            for (int i = 0; i < rowNum; i++)
            {
                string line = Console.ReadLine();

                if (line.Length != symbolsNum)
                {
                    throw new System.ArgumentException("Please enter the correct number of symbols."); ;
                }
                else
                {
                    lines.Add(line);
                }
            }

            string[] linesArr = lines.ToArray();

            Console.WriteLine("Input word we are looking for: ");
            string word = Console.ReadLine();

            string wordBuilder = "";

            int result = 0;

            for (int x = 0; x < rowNum; x++)
            {
                for (int y = 0; y < symbolsNum; y++)
                {
                    if (linesArr[x][y] == word[0])
                    {      
                        for (int z = 0; z < word.Length; z++)
                        {
                            if (linesArr[x][y + z] == word[z] && y + word.Length <= linesArr[x].Length)
                            {
                                wordBuilder = wordBuilder + word[z];
                                if (wordBuilder == word)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        wordBuilder = "";

                        for (int z = 0; z < word.Length; z++)
                        {
                            if (linesArr[x][y - z] == word[z] && y - word.Length >= -1)
                            {
                                wordBuilder = wordBuilder + word[z];
                                if (wordBuilder == word)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        wordBuilder = "";

                        for (int z = 0; z < word.Length; z++)
                        {
                            if (linesArr[x + z][y] == word[z] && x + word.Length <= linesArr.Length)
                            {
                                wordBuilder = wordBuilder + word[z];
                                if (wordBuilder == word)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        wordBuilder = "";

                        for (int z = 0; z < word.Length; z++)
                        {
                            if (linesArr[x - z][y] == word[z] && x - word.Length >= -1)
                            {
                                wordBuilder = wordBuilder + word[z];
                                if (wordBuilder == word)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        wordBuilder = "";

                        for (int z = 0; z < word.Length; z++)
                        {
                            if (linesArr[x - z][y - z] == word[z] && x - word.Length >= -1 && y - word.Length >= -1)
                            {
                                wordBuilder = wordBuilder + word[z];
                                if (wordBuilder == word)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        wordBuilder = "";

                        for (int z = 0; z < word.Length; z++)
                        {
                            if (linesArr[x + z][y - z] == word[z] && x + word.Length <= linesArr.Length && y - word.Length >= -1)
                            {
                                wordBuilder = wordBuilder + word[z];
                                if (wordBuilder == word)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        wordBuilder = "";

                        for (int z = 0; z < word.Length; z++)
                        {
                            if (linesArr[x - z][y + z] == word[z] && x - word.Length >= -1 && y + word.Length <= linesArr[x].Length)
                            {
                                wordBuilder = wordBuilder + word[z];
                                if (wordBuilder == word)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        wordBuilder = "";

                        for (int z = 0; z < word.Length; z++)
                        {
                            if (linesArr[x + z][y + z] == word[z] && x + word.Length <= linesArr.Length && y + word.Length <= linesArr[x].Length)
                            {
                                wordBuilder = wordBuilder + word[z];
                                if (wordBuilder == word)
                                {
                                    result++;
                                }
                            }
                            else
                            {
                                break;
                            }
                        }
                        wordBuilder = "";
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
