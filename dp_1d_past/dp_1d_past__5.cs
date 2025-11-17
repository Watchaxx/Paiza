// 実行時間 70ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        bool[] b = Repeat( true, n + 1 ).ToArray();
        int[] d = Repeat( int.MaxValue, n + 1 ).ToArray();
        var p = new System.Collections.Generic.List<int>();

        b[0] = false;
        b[1] = false;
        foreach( int i in Range( 2, n - 1 ).Where( x => b[x] ) ) {
            int j = 2 * i;

            while( j <= n ) {
                b[j] = false;
                j += i;
            }
        }
        d[0] = 0;
        foreach( int i in Range( 0, n + 1 ).Where( x => b[x] ) ) {
            p.Add( i );
        }
        foreach( int i in Range( 0, n + 1 ) ) {
            foreach( int j in p ) {
                int q = j;

                if( i - q < 0 ) {
                    break;
                } else if( d[i - q] != int.MaxValue ) {
                    d[i] = System.Math.Min( d[i], d[i - q] + 1 );
                }
            }
        }
        WriteLine( d[n] );
        return;
    }
}
