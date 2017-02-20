using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharHistogram
{
    class Program
    {
        public static Dictionary<char, int> CharHistogram(string n)
        {
            string histogramStr = n;
            Dictionary<char, int> histogramDic = new Dictionary<char, int>();

            for (int i = 0; i < histogramStr.Length; i++)
            {
                if (!histogramDic.ContainsKey(histogramStr[i]))
                {
                    histogramDic.Add(histogramStr[i], 1);
                }
                else
                {
                    histogramDic[histogramStr[i]]++;
                }
            }

            return histogramDic;
        }
        static void Main()
        {
            foreach (KeyValuePair<char, int> item in CharHistogram("praprazse"))
            {
                Console.WriteLine("{0}:{1}", item.Key, item.Value);
            }
        }
    }
}
