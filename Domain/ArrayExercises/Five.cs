using System.Linq;

namespace Domain.ArrayExercises
{
    public class Five
    {
        public Five()
        {
            var numOfDups = 0;
            var arr = new int[] { 1,2,2,2,2,3,3,3,3};

            for (var i = 0; i < arr.Length; i++)
            {
                while (i != arr.Length)
                {
                    if (arr[i] == arr[i + 1])
                    {
                        numOfDups++;
                    }
                }   
            }
        }
    }
}