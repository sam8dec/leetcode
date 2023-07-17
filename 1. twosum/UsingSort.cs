public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] numsCopy = (int[])nums.Clone();
        Array.Sort(numsCopy);
        int i=0,j=nums.Length-1;
        while (i < j)
        {
            if (numsCopy[i] + numsCopy[j] == target)
                break;
            else if (numsCopy[i] + numsCopy[j] < target)
                i++;
            else
                j--;
        }
        int firstIndex = -1, lastIndex = -1;
        firstIndex = Array.IndexOf(nums, numsCopy[i]);
        if (numsCopy[i] == numsCopy[j])
        {
            lastIndex = Array.LastIndexOf(nums, numsCopy[j]);
        }
        else
        {
            lastIndex = Array.IndexOf(nums, numsCopy[j]);
        }
        return new int[] {firstIndex, lastIndex};
    }
}