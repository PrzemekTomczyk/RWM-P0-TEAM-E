using System.Collections.Generic;
using System.Linq;

public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return RunningTotalFilter.runningTotal(Modulo3.modulo3(XOR21Filter.XOR21s(xs)).ToList<int>()).ToArray();
    }
}