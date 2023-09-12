public class Solution {
    public string ModifyString(string s) {
      var letters = "abcdefghijklmnopqrstuvwxyz";
      var rnd = new Random();

      if (s.Length < 1) return s;
      if (s.Length == 1 && s[0] == '?') return "a"; 

      var charArr = s.ToArray();

      for (int i = 0; i < charArr.Length; i++)
      {
        if (charArr[i] is not '?') continue;

        bool isLast = i == s.Length - 1;
        bool isFirst = i == 0;

        if (!isFirst && !isLast)
        {
          var prev = charArr[i - 1];
          var next = charArr[i + 1];

          char charToReplace = 'a';
          while (prev.Equals(charToReplace) || next.Equals(charToReplace)) {
            charToReplace = GetRandomCharacter(letters, rnd);
          }

          charArr[i] = charToReplace;
        }
        else
        {
          var charToCompare = isFirst ? charArr[i + 1] : charArr[i - 1];

          char charToReplace = 'a';
          while (charToCompare.Equals(charToReplace)) {
            charToReplace = GetRandomCharacter(letters, rnd);
          }

          charArr[i] = charToReplace;
        }
      }

      return new string(charArr);
    }

    public static char GetRandomCharacter(string text, Random rnd)
    {
      int index = rnd.Next(text.Length);
      return text[index];
    }
}