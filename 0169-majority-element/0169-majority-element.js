/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function(nums) {
    const map = new Map()

    for (let num of nums) {
        const val = map.get(num)

        if (val) {
            map.set(num, val + 1)
        } else {
            map.set(num, 1)
        }
    }

    for (let key of map.keys()) {
        if (map.get(key) >= nums.length / 2)
            return key
    }

    return 0
};