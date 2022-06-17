namespace Algorithms {
    internal class QuickSort {

        internal static void Sort(int[] input) {
            Sort(input, 0, input.Length - 1);
        }

        internal static void Sort(int[] input, int left, int right) {
            if (left == right) {
                return;
            }
            int pivot = (left + right) / 2;
            int element = input[pivot];
            int i = left;
            int j = right;
            while (i < j) {
                if (input[i] >= element && input[j] <= element) {
                    int t = input[i];
                    input[i] = input[j];
                    input[j] = t;
                }
                if (input[i] <= element) {
                    ++i;
                }
                if (input[j] >= element) {
                    --j;
                }
            }
            Sort(input, i, right);
            Sort(input, left, j);
        }
    }
}
