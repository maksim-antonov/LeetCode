/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function(nums) {
    if (nums.length === 0) return 0;

    let k = 1;
    let i = 0

    while (i < nums.length) {
        if (nums[i] === nums[k-1]) {
            i++;
            continue;
        }

        // Copy it to the k-th position in the array
        nums[k] = nums[i];
        // Increment k and i by one
        k++;
        i++;
    }

    return k;
};