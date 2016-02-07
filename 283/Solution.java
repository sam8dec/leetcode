package com.leetcode.p283;

public class Solution {
	public void moveZeroes(int[] nums) {
        int iz = -1,t;
        for (int i=0;i<nums.length;i++) {
        	if(nums[i]!=0 && iz>=0) {
        		nums[iz]=nums[i];nums[i]=0;iz++;
        	}
        	else if (nums[i]==0 && iz==-1) {
        		iz=i;
        	}
        }
    }
	
	public static void main(String[] args) {
		int[] nums = {0,1,1};
	    Solution s = new Solution();
	    s.moveZeroes(nums);
	    for(int i=0;i<nums.length;i++) {
	    	System.out.println(nums[i]);
	    }
	}

}
