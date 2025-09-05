using System;

//IArray

namespace ArrayandStringLibrary.Interfaces
{
    public interface IArray
    {
        void UpdateArray(int[] numbers);
        void ShowArrays();
        void FindInArray(int? target, bool? getLargest);
        void LinearSearch(int target, bool printSteps);
    }
}