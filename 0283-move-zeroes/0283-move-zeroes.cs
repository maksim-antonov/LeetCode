public class Solution {
    public void MoveZeroes(int[] nums) {
        for (int i = 0, j = 0; j < nums.Length; j++)
        {
            if (nums[j] == 0) continue;
            (nums[j], nums[i]) = (nums[i], nums[j]);
            i++;
        }
    }
}