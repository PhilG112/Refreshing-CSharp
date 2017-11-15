using System;

namespace Domain.ArrayExercises
{
    public class Four
    {
        public Four()
        {
            var arr1 = new int[] {1,2,3,4,5};
            var arr2 = new int[] { };
            arr1.CopyTo(arr2, 0);
        }
    }
}