using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagrams
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
        public static bool IsAnagram(string a, string b)
        {
            string strA = a;
            string strB = b;
            bool isAnagram = false;
            string anagramA = "";
            string anagramB = "";

            List<char> listA = new List<char>();
            List<char> listB = new List<char>();

            for (int i = 0; i < strA.Length; i++)
            {
                listA.Add(strA[i]);
            }
            for (int i = 0; i < strB.Length; i++)
            {
                listB.Add(strB[i]);
            }
            listA.Sort();
            listB.Sort();

            for (int i = 0; i < listA.Count; i++)
            {
                anagramA += listA[i];
            }
            for (int i = 0; i < listB.Count; i++)
            {
                anagramB += listB[i];
            }

            if (anagramA == anagramB)
            {
                isAnagram = true;
            }

            return isAnagram;
        }

        public static bool HasAnagram(string a, string b)
        {
            Dictionary<char, int> abagramDicB = CharHistogram(b);
            Dictionary<char, int> abagramDicА = CharHistogram(a);
            
            foreach (KeyValuePair<char, int> item in abagramDicА)
            {
                if(!abagramDicB.ContainsKey(item.Key) ||
                    abagramDicB[item.Key] < item.Value)
                {
                    return false;
                }

            }

            return true;
        }
        static void Main()
        {
            Console.WriteLine(IsAnagram("radin", "nidar"));
        }
    }
}
