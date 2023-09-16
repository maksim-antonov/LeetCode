/**
 * @param {number[]} nums
 * @return {number}
 */
var removeDuplicates = function(nums) {
    if (nums.length === 0) return;

    let k = 1;
    let prev = nums[0];

    // Loop through the array, starting from the second element
    for (let i = 1; i < nums.length; i++) {
        if (nums[i] === prev) continue;

        // Copy it to the k-th position in the array
        nums[k] = nums[i];
        // Increment k by one
        k++;
        // Update prev
        prev = nums[i];
    }

    return k;
};