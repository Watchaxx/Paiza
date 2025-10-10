// 実行時間 340ms
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
        while( 1 < r - l ) {
            ulong m = ( l + r ) / 2UL;
            ulong o = 0UL;

            foreach( int i in Range( 0, n ) ) {
                o += System.Math.Min( a[i][0] * m + a[i][1], a[i][2] * m + a[i][3] );
            }
            if( o <= k ) {
                l = m;
            } else {
                r = m;
            }
        }
        WriteLine( l );
        return;
    }
}
