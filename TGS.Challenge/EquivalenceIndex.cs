namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class EquivalenceIndex
    {
      public int Find(int[] numbers)
      {
            // get numbers array length
            int arrSize = numbers.Length;

            int leftSum = 0;
            int rightSum = 0;

            // calculate rightSum after index 1 of numbers array
            for (int i = 1; i < arrSize; i++)
            {
                rightSum += numbers[i];
            }

            // checking the point where left_Sum == right_sum in numbers array
            for (int i = 0, j = 1; j < arrSize; i++, j++)
            {
                // for each Index moved to the right - value from rightSum
                rightSum -= numbers[j];

                // for each index moved to the right + value to leftSum
                leftSum += numbers[i];

                // if leftSum == rightSum return element Index
                if (leftSum == rightSum)
                    return i + 1;
            }

            return -1;
      }
    }
}
