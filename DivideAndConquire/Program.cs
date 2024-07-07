using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (TestInversionCount())
            {
                Console.WriteLine("InversionCount passed all tests");
            }
            else
            {
                Console.WriteLine("InversionCount did not pass all tests");
            }
            if (TestGetMiddleKey())
            {
                Console.WriteLine("GetMedianKey passed all tests");
            }
            else
            {
                Console.WriteLine("GetMedianKey did not pass all tests");
            }
        }

        static bool TestInversionCount()
        {
            int[] emptyArray = new int[0];
            int emptyInversionCount = 0;
            if (Inversion.InversionCount(emptyArray) != emptyInversionCount)
            {
                return false;
            }

            int[] oneElementArray = new int[0];
            int oneElementInversionCount = 0;
            if (Inversion.InversionCount(oneElementArray) != oneElementInversionCount)
            {
                return false;
            }

            int[] ascendingArray = { 1, 2, 3, 4 };
            int ascendingInversionCount = 0;
            if (Inversion.InversionCount(ascendingArray) != ascendingInversionCount)
            {
                return false;
            }

            int[] descendingArray = { 4, 3, 2, 1 };
            int descendingInversionCount = (descendingArray.Length * (descendingArray.Length - 1)) / 2;
            if (Inversion.InversionCount(descendingArray) != descendingInversionCount)
            {
                return false;
            }

            int[] exampleArray = { 3, 2, 4, 1 };
            int exampleInversionCount = 4;
            if (Inversion.InversionCount(exampleArray) != exampleInversionCount)
            {
                return false;
            }

            return true;
        }

        static bool TestGetMiddleKey()
        {
            int[] emptyArr1 = new int[0];
            int[] emptyArr2 = new int[0];
            if (MedianKeyOfArrays.GetMedianKey(emptyArr1, emptyArr2) != null)
            {
                return false;
            }

            int middle = 6;

            int[] oneElementArr1 = { 6 };
            int[] oneElementArr2 = { 25 };
            if (MedianKeyOfArrays.GetMedianKey(oneElementArr1, oneElementArr2) != middle)
            {
                return false;
            }

            int[] repeatingKeyArr1 = { -1, 4, 6, 10 };
            int[] repeatingKeyArr2 = { 1, 6, 6, 8 };
            if (MedianKeyOfArrays.GetMedianKey(repeatingKeyArr1, repeatingKeyArr2) != middle)
            {
                return false;
            }

            int[] middleAtEndOfXArr1 = { 1, 2, 3, 4, 5, 6 };
            int[] middleAtEndOfXArr2 = { 7, 8, 9, 10, 11, 12 };
            if (MedianKeyOfArrays.GetMedianKey(middleAtEndOfXArr1, middleAtEndOfXArr2) != middle)
            {
                return false;
            }

            int[] middleAtEndOfYArr2 = { 1, 2, 3, 4, 5, 6 };
            int[] middleAtEndOfYArr1 = { 7, 8, 9, 10, 11, 12 };
            if (MedianKeyOfArrays.GetMedianKey(middleAtEndOfYArr1, middleAtEndOfYArr2) != middle)
            {
                return false;
            }

            int[] middleAtXArr1 = { 5, 6, 7, 9, 10, 12 };
            int[] middleAtXArr2 = { 1, 2, 3, 4, 8, 11 };
            if (MedianKeyOfArrays.GetMedianKey(middleAtXArr1, middleAtXArr2) != middle)
            {
                return false;
            }

            int[] middleAtYArr1 = { 1, 5, 7, 8, 9, 10 };
            int[] middleAtYArr2 = { 2, 3, 4, 6, 11, 12 };
            if (MedianKeyOfArrays.GetMedianKey(middleAtYArr1, middleAtYArr2) != middle)
            {
                return false;
            }

            return true;
        }
    }
}
