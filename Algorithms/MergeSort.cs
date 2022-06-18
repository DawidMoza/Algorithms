namespace Algorithms {
    internal static class MergeSort {

        internal static int[] SortRecursive(int[] input) {
            if (input.Length == 1) {
                return input;
            }
            int[] a = SortRecursive(input.ToList().GetRange(0, input.Length / 2).ToArray());
            int[] b = SortRecursive(input.ToList().GetRange(input.Length / 2, input.Length - (input.Length / 2)).ToArray());
            return Merge(a, b);
        }

        internal static void SortIterative(int[] input) {
            for (int i = 1; i < input.Length - 1; i *= 2) {
                for (int j = 0; j < input.Length - 1; j += 2 * i) {
                    int mid = Math.Min(j + i - 1, input.Length - 1);
                    int end = Math.Min(j + 2 * i - 1, input.Length - 1);
                    Merge(input, j, mid, mid + 1, end);
                }
            }
        }

        private static int[] Merge(int[] a, int[] b) {
            int[] result = new int[a.Length + b.Length];
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < a.Length || j < b.Length) {    
                if (i == a.Length) {
                    result[k++] = b[j++];
                } else if (j == b.Length) {
                    result[k++] = a[i++];
                } else if (a[i] < b[j]) {
                    result[k++] = a[i++];
                } else { 
                    result[k++] = b[j++];
                }
            }
            return result;
        }

        private static void Merge(int[] input, int leftFirst, int rightFirst, int leftSecond, int rightSecond) {
            int[] a = input.ToList().GetRange(leftFirst, rightFirst - leftFirst + 1).ToArray();
            int[] b = input.ToList().GetRange(leftSecond, rightSecond - leftSecond + 1).ToArray();
            int[] merged = Merge(a, b);
            int k = 0;
            for (int i = leftFirst; i <= rightSecond; ++i) {
                input[i] = merged[k++];
            }
        }
    }
}
