/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function(nums) {
    nums.sort((a, b) => a - b);

    function myRound(num) {
        if (num % 1 === 0) return num;
        if (num % 1 <= 0.5) return Math.floor(num);
        else return Math.ceil(num)
    }

    return nums[myRound(nums.length/2)];
};