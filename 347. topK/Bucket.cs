public class Solution
{
    public int[] TopKFrequent(int[] nums, int k)
    {
        List<int> ret = new List<int>();
        Dictionary<int, int> numToFreq = new Dictionary<int, int>();
        List<int>[] freqToNums = new List<int>[nums.Length + 1];
        foreach (int num in nums)
        {
            if (!numToFreq.ContainsKey(num))
            {
                numToFreq.Add(num, 0);
            }
            numToFreq[num]++;
        }
        foreach (int num in numToFreq.Keys)
        {
            if (freqToNums[numToFreq[num]] == null)
            {
                freqToNums[numToFreq[num]] = new List<int>();
            }
            freqToNums[numToFreq[num]].Add(num);
        }
        for (int freq = nums.Length; freq >= 1; freq--)
        {
            if (freqToNums[freq] != null)
            {
                foreach (int num in freqToNums[freq])
                {
                    ret.Add(num);
                    k--;
                    if (k == 0)
                    {
                        return ret.ToArray();
                    }
                }
            }
        }
        return ret.ToArray();
    }
}