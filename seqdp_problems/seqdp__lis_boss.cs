// 実行時間 80ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 1;
        long[] a = ReadLine().Split().Select( long.Parse ).ToArray();
        var d = new System.Collections.Generic.Dictionary<long, int>( n );

        foreach( long l in a ) {
            d[l] = 1;
            if( l % 2 == 1 ) {
                continue;
            }
            if( d.ContainsKey( l / 2 ) == true ) {
                d[l] = d[l / 2] + 1;
                o = System.Math.Max( o, d[l] );
            }
        }
        WriteLine( o );
        return;
    }
}
