namespace Algorithms {
    internal static class NoComparisonSorts {

        internal static int[] CountingSort(int[] input) { 
            List<int> result = new List<int>();
            int min = input.ToList().Min();
            int max = input.ToList().Max();
            int[] counts = new int[max - min + 1];
            foreach (int x in input) {
                ++counts[x - min];
            }
            for (int i = 0; i < counts.Length; ++i) {
                for (int j = 0; j < counts[i]; ++j) {
                    result.Add(i + min);
                }
            }
            return result.ToArray();
        }

        internal static int[] RadixSort(int[] input) {
            int[] counts = new int[10];
            int max = input.ToList().Max();
            int maxPower = max.ToString().Length - 1;
            int[] result = new int[input.Length];
            input.CopyTo(result, 0);
            for (int i = 0; i <= maxPower; ++i) {
                result = CountingSort(result, i);
            }
            return result;
        }

        private static int[] CountingSort(int[] input, int position) {
            List<int> result = new List<int>();
            List<int>[] counts = new List<int>[10];
            for (int i = 0; i < 10; ++i) {
                counts[i] = new List<int>();
            }
            foreach (int x in input) {
                counts[GetOnPostion(x, position)].Add(x); 
            }
            foreach (List<int> list in counts) {
                foreach (int x in list) {
                    result.Add(x);
                }
            }
            return result.ToArray();
        }

        private static int GetOnPostion(int x, int position) {
            string converted = x.ToString();
            if (converted.Length - 1 < position) {
                return 0;
            }
            return int.Parse(converted[converted.Length - 1 - position].ToString());
        }

        internal static int[] BucketSort(int[] input) {
            int min = input.ToList().Min();
            double max = input.ToList().Max() + 1;
            List<int> result = new List<int>();
            List<int>[] counts = new List<int>[10];
            for (int i = 0; i < 10; ++i) {
                counts[i] = new List<int>();
            }
            foreach (int x in input) {
                counts[(int) ((x - min) / max) * counts.Length].Add(x);
            }
            foreach (List<int> list in counts) {
                list.Sort();
            }
            foreach (List<int> list in counts) {
                foreach (int x in list) {
                    result.Add(x);
                }
            }
            return result.ToArray();
        }
    }
}
