// 実行時間 20ms
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        long[] nxk = ReadLine().Split( ' ' ).Select( long.Parse ).ToArray();
        long o = nxk[2] - nxk[0] * 4;

        WriteLine( o % 4 == 3
            ? o / 4 * 2 * nxk[1] + nxk[1]
            : o / 4 * 2 * nxk[1] );
        return;
    }
}
