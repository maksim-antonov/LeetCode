/**
 * @param {number[]} nums
 * @return {number}
 */
const removeDuplicates = (nums) => {
    if (nums.length === 0) return 0;

    let k = 0;
    let i = 1;

    while (i < nums.length) {
        if (nums[i] !== nums[k]) {
            nums[++k] = nums[i]
        }

        i++;
    }

    return k + 1;
};