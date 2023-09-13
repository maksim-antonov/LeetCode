/**
 * @param {number[]} height
 * @return {number}
 */
var maxArea = function(height) {
    // height = [1,8,6,2,5,4,8,3,7]
    // should output 49
    // because 8 (index 1) is maximum and 7 (index 8) could contain 49 (index 8 - index 1 * smaller height),

    let leftIndex = 0
    let rightIndex = height.length - 1
    let maxContainerVolume = 0

    while (leftIndex < rightIndex) {
        const leftHeight = height[leftIndex]
        const rightHeight = height[rightIndex]
        const containerWidth = rightIndex - leftIndex
        const smallerHeight = leftHeight < rightHeight ? leftHeight : rightHeight
        const containerVolume = containerWidth * smallerHeight

        maxContainerVolume = containerVolume > maxContainerVolume ? containerVolume : maxContainerVolume
        smallerHeight === leftHeight ? leftIndex++ : rightIndex--
    }

    return maxContainerVolume
};