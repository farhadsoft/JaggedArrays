using System;

#pragma warning disable S2368

namespace JaggedArrays
{
    public static class ArrayExtension
    {
        /// <summary>
        /// Orders the rows in a jagged-array by ascending of the sum of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByAscendingBySum(this int[][] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (int i = source.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (GetArraySum(source[j]) > GetArraySum(source[j + 1]))
                    {
                        var temp = source[j];
                        source[j] = source[j + 1];
                        source[j + 1] = temp;
                    }
                }
            }
        }

        public static int GetArraySum(int[] array)
        {
            if (array is null)
            {
                return -1;
            }

            int result = 0;
            for (int i = 0; i < array.Length; i++)
            {
                result += array[i];
            }

            return result;
        }
        
        /// <summary>
        /// Orders the rows in a jagged-array by descending of the sum of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByDescendingBySum(this int[][] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (int i = source.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (GetArraySum(source[j]) < GetArraySum(source[j + 1]))
                    {
                        var temp = source[j];
                        source[j] = source[j + 1];
                        source[j + 1] = temp;
                    }
                }
            }
        }
        
        /// <summary>
        /// Orders the rows in a jagged-array by ascending of the max of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByAscendingByMax(this int[][] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (int i = source.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (GetMaxValue(source[j]) > GetMaxValue(source[j + 1]))
                    {
                        var temp = source[j];
                        source[j] = source[j + 1];
                        source[j + 1] = temp;
                    }
                }
            }
        }

        public static int GetMaxValue(int[] array)
        {
            if (array is null)
            {
                return -1;
            }

            int result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (result < array[i])
                {
                    result = array[i];
                }
            }

            return result;
        }
        
        /// <summary>
        /// Orders the rows in a jagged-array by descending of the max of the elements in them.
        /// </summary>
        /// <param name="source">The jagged-array to sort.</param>
        /// <exception cref="ArgumentNullException">Thrown when source in null.</exception>
        public static void OrderByDescendingByMax(this int[][] source)
        {
            if (source is null)
            {
                throw new ArgumentNullException(nameof(source));
            }

            for (int i = source.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (GetMaxValue(source[j]) < GetMaxValue(source[j + 1]))
                    {
                        var temp = source[j];
                        source[j] = source[j + 1];
                        source[j + 1] = temp;
                    }
                }
            }
        }
    }
}
