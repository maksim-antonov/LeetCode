public class Solution {
    public int SearchInsert(int[] nums, int target) {
        var left = 0;
        var right = nums.Length - 1;

        while (right >= left)
        {
            var mid = (left + right) / 2;

            if (target == nums[mid])
                return mid;

            if (target < nums[mid])
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left;
    }
}