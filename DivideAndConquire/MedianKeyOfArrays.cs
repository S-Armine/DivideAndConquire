using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideAndConquer
{
    public class MedianKeyOfArrays
    {
        public static int? GetMedianKey(int[] X, int[] Y)
        {
            if (X.Length == 0)
            {
                return null;
            }
            return GetMedianKeyRecursive(X, Y, 0, X.Length - 1);
        }

        private static int GetMedianKeyRecursive(int[] X, int[] Y, int left, int right)
        {
            if (left > right)
            {
                return GetMedianKeyRecursive(Y, X, 0, Y.Length - 1);
            }
            int middle = (left + right) / 2;
            int predecessor = X.Length - middle - 2;
            if (predecessor < 0 && X[middle] < Y[0])
            {
                return X[middle];
            }
            if (X[middle] >= Y[predecessor] && X[middle] <= Y[predecessor + 1])
            {
                return X[middle];
            }
            if (X[middle] < Y[predecessor])
            {
                return GetMedianKeyRecursive(X, Y, middle + 1, right);
            }
            return GetMedianKeyRecursive(X, Y, left, middle - 1);
        }
    }
}
