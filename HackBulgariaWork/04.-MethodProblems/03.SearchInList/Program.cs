using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchInList
{
    class Program
    {
        public static bool TryFindSubstring(List<string> list, string searched, out int foundIndex)
        {
            List<string> searchForStr = new List<string>(list);
            string searchingFor = searched;
            bool foundSubstring = false;
            foundIndex = 0;
            
            for (int i = 0; i < searchForStr.Count; i++)
			{
                if (searchForStr[i].Contains(searchingFor))
                {
                    foundIndex = i;
                    foundSubstring = true;
                    break;
                }
			}

            return foundSubstring;
        }

        static void Main()
        {
        }
    }
}
