// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int x = int.Parse( ReadLine() );
        int[] f = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] ln = ReadLine().Split().Select( int.Parse ).ToArray();
        long c = 0L;
        long o = 0L;
        var s = new System.Collections.Generic.List<int>( ReadLine().Split().Select( int.Parse ) ) { ln[0] };

        foreach( int i in Range( 0, ln[1] + 1 ) ) {
            o += x < s[i] - c ? f[0] * x + f[1] * ( s[i] - c - x ) : f[0] * ( s[i] - c );
            c = s[i];
        }
        WriteLine( o );
        return;
    }
}
