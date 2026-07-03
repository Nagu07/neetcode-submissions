public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> counter = new Dictionary<int, int>();

        // I have got count of occurences
        foreach (int i in nums) {
            if (!counter.ContainsKey(i)) {
                counter[i] = 0;
            } else {
                counter[i]++;
            }
        }

        // bucket
        List<int>[] bucketArr = new List<int>[nums.Length];
        int[] res = new int[k];
        int resultArrIndex = k - 1;

        foreach (var i in counter) {
            if (bucketArr[i.Value] == null) {
                bucketArr[i.Value] = new List<int> { i.Key };
            } else {
                bucketArr[i.Value].Add(i.Key);
            }
        }

        for (int i = bucketArr.Length - 1; i >= 0; i--) {
            if (bucketArr[i] != null) {
                foreach (var z in bucketArr[i]) {
                    if (bucketArr[i].Count() > 0 && resultArrIndex >= 0) {
                        res[resultArrIndex] = z;
                        resultArrIndex--;
                    }
                }
            }
        }

        return res;
    }
}
