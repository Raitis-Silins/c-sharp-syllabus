using System;
using System.Linq;

namespace Exercise6
{
    public class RandomArray
    {
        public int[] CreateArray(int arrLength)
        {
            Random random = new Random();
            var array = new int[arrLength].Select(num => random.Next(1, 100)).ToArray();
            return array;
        }

        public int[] ArrayClone(int[] array)
        {
            var clonedArray = new int[array.Length];
            Array.Copy(array, clonedArray, array.Length);
            clonedArray[9] = -7;
            return clonedArray;
        }

        public int[] CopyFirstArrayToNewArray(int[] array)
        {
            var copyOfArray = new int[array.Length];
            Array.Copy(array, copyOfArray, array.Length);
            return copyOfArray;
        }

        public string DisplayArray(int[] array)
        {
            return string.Join(" ", array);
        }
    }
}