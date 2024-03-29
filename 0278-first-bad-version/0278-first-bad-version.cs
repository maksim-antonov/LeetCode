/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        long low = 1;
        long high = n;
        while (high >= low)
        {
            long mid = (low + high) / 2;
            if (!IsBadVersion((int) mid))
                low = mid + 1;
            else
            {
                high = mid - 1;
            }
        }
    
        return (int) low;
    }
}