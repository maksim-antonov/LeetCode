public class Solution {
    public int Reverse(int x) {
        string str;
        bool isNegative;

        if (x < 0) {
            str = x.ToString().Substring(1);
            isNegative = true;
        }
        else {
            str = x.ToString();
            isNegative = false;
        }

        var outNum = 0;
        var strArr = str.ToArray();
        for (var i = 0; i < strArr.Length / 2; i++) {
            var temp = strArr[strArr.Length - (1 + i)];
            strArr[strArr.Length - 1 - i] = strArr[i];
            strArr[i] = temp;
        }

        str = string.Join("", strArr);

        if (isNegative) 
            str = "-" + str;

        if (int.TryParse(str, out var num)) {
            return num;
        }
        else {
            return 0;
        }
    }
}