using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackNumbers
{
    class Program
    {
        public static int NextHack(int n)
        {
            int currentNum = n;
            int nextHackNum;

            while (true)
            {
                currentNum += 1;
                if (IsHack(currentNum))
                {
                    nextHackNum = currentNum;
                    break;
                }
            }
            return nextHackNum;
        }

        public static bool IsHack(int n)
        {
            List<int> binary = new List<int>();

            bool oddOnes = false;
            bool palindrome = true;
            bool isHackNumber = false;
            int onesCount = 0;
            int hackNum = n;

            while (n > 0)
            {
                binary.Add(hackNum % 2);
                hackNum = hackNum / 2;
            }

            List<int> reverseBinary = new List<int>(binary);
            binary.Reverse();

            for (int i = 0; i < binary.Count; i++)
            {
                if (binary[i] % 2 == 1)
                {
                    onesCount++;
                }
            }

            for (int i = 0; i < binary.Count; i++)
            {
                if (binary[i] != reverseBinary[i])
                {
                    palindrome = false;
                    break;
                }
            }

            if (onesCount % 2 == 1)
            {
                oddOnes = true;
            }
            if (palindrome == true && oddOnes == true)
            {
                isHackNumber = true;
            }

            return isHackNumber;

        }
        static void Main(string[] args)
        {
        }
    }
}
