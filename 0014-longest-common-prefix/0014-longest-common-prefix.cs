public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        switch (strs.Length)
        {
            case 0: return "";
            case 1: return strs[0];
        }

        var prefixLength = 0;

        foreach (var c in strs[0])
        {
            if (strs.Any(s => s.Length <= prefixLength || s[prefixLength] != c))
            {
                return strs[0][..prefixLength];
            }

            prefixLength++;
        }

        return strs[0];
    }
}