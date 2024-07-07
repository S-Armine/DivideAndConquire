using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public class Inversion
    {
        public static int InversionCount(int[] arr)
        {
            int count = 0;
            int[] arrCopy = new int[arr.Length];
            Array.Copy(arr, arrCopy, arr.Length);
            Divide(arrCopy, 0, arrCopy.Length - 1, ref count);
            return count;
        }

        private static void Divide(int[] arr, int left, int right, ref int count)
        {
            if (left < right)
            {
                int middle = (left + right) / 2;
                Divide(arr, left, middle, ref count);
                Divide(arr, middle + 1, right, ref count);
                Merge(arr, left, right, ref count);
            }
        }

        private static void Merge(int[] arr, int left, int right, ref int count)
        {
            int middle = (left + right) / 2;
            int leftArrSize = middle - left + 1;
            int[] leftArr = new int[leftArrSize];
            int rightArrSize = right - middle;
            int[] rightArr = new int[rightArrSize];
            for (int i = 0; i < leftArrSize; i++)
            {
                leftArr[i] = arr[left + i];
            }
            for (int i = 0; i < rightArrSize; i++)
            {
                rightArr[i] = arr[middle + i + 1];
            }
            int leftIndex = 0;
            int rightIndex = 0;
            int index = left;
            while (leftIndex < leftArrSize && rightIndex < rightArrSize)
            {
                if (leftArr[leftIndex] <= rightArr[rightIndex])
                {
                    arr[index++] = leftArr[leftIndex++];
                }
                else
                {
                    arr[index++] = rightArr[rightIndex++];
                    count += leftArrSize - leftIndex;
                }
            }
            while (leftIndex < leftArrSize)
            {
                arr[index++] = leftArr[leftIndex++];
            }
            while (rightIndex < rightArrSize)
            {
                arr[index++] = rightArr[rightIndex++];
            }
        }
    }
}
