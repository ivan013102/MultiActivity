using ArrayandStringLibrary.Interfaces;
using System;
using System.Linq;

//MArray

namespace ArrayandStringLibrary.Methods
{
    public class ArrayProcessor : IArray
    {
        private int[] _numbers;

        public ArrayProcessor(int[] numbers)
        {
            _numbers = numbers ?? throw new ArgumentNullException(nameof(numbers));
        }

        public void ShowArrays()
        {
            Console.WriteLine("Original Array:");
            DisplayArray(_numbers);

            var flipped = GetReversedArray(_numbers);
            Console.WriteLine("\nReversed Array:");
            DisplayArray(flipped);
        }

        public void FindInArray(int? target, bool? getLargest)
        {
            if (getLargest ?? false)
            {
                Console.WriteLine($"\nLargest Element: {_numbers.Max()}");
            }
        }


        public void UpdateArray(int[] numbers)
        {
            _numbers = numbers;
        }

        private int[] GetReversedArray(int[] numbers)
        {
            int[] reversed = new int[numbers.Length];
            int index = 0;

            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                reversed[index] = numbers[i];
                index++;
            }

            return reversed;
        }

        public void LinearSearch(int target, bool printSteps)
        {
            if (_numbers == null) throw new ArgumentNullException(nameof(_numbers));

            if (printSteps)
            {
                Console.WriteLine("\nExecuting Linear Search...");
                Console.WriteLine(string.Join(" ", _numbers));
            }

            int position = LocateTarget(target);

            if (position != -1)
            {
                Console.WriteLine($"\nTarget {target} found at index {position}.");
            }
            else
            {
                Console.WriteLine($"\nTarget {target} not present in the array.");
            }
        }

        public int LocateTarget(int target)
        {
            for (int i = 0; i < _numbers.Length; i++)
            {
                if (_numbers[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
        private void DisplayArray(int[] numbers)
        {
            foreach (var value in numbers)
            {
                Console.Write($"{value} ");
            }
        }
    }
}