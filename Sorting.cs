namespace Sorting
{
    static public class Sort
    {
        static public int[] Bubble(int[] input)
        {
            // Increment through each array element
            // Compare [n], [n+1]
            // If [n] > [n+1], swap elements
            // Once final element is reached, iterate
            // If no swaps have been made, return sorted array

            int[] sortedList = input;
            int swapCount;

            do {
                swapCount = 0;
                for (int n = 1; n < sortedList.Length; n++)
                {
                    // Store current element
                    int t = sortedList[n];

                    // Compare to previous element
                    if (sortedList[n - 1] > t)
                    {
                        sortedList[n] = sortedList[n - 1];
                        sortedList[n - 1] = t;
                        swapCount++; // Increment counter every time a swap occurs
                    }
                }
            } while (swapCount > 0);

            return sortedList;
        }

        static public int[] Insertion(int[] input)
        {
            int[] sortedList = input;

            return sortedList;
        }
    }
}