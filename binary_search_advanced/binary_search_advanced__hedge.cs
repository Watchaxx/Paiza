// 実行時間 370ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        string[] s = ReadLine().Split();
        int n = int.Parse( s[0] );
        ulong k = ulong.Parse( s[1] );
        ulong l = 0UL;
        ulong r = 1UL << 24;
        uint[][] a = new uint[n][];

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( uint.Parse ).ToArray();
        }
        while( 1UL < r - l ) {
            bool b = true;
            ulong m = ( l + r ) / 2UL;

            foreach( int _ in Range( 0, n ).Where( x => a[x][0] * m * m + a[x][1] * m + a[x][2] < k ) ) {
                b = false;
                break;
            }
            if( b == true ) {
                r = m;
            } else {
                l = m;
            }
        }
        WriteLine( r );
        return;
    }
}
