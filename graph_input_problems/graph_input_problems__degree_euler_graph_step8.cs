// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] li = new int[n[0]];
        int[] lo = new int[n[0]];

        foreach( int _ in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            li[t[1]]++;
            lo[t[0]]++;
        }
        foreach( int _ in Range( 0, n[0] ).Where( x => li[x] != lo[x] ) ) {
            goto Nx;
        }
        WriteLine( 1 );
        return;
    Nx:
        if( Range( 0, n[0] ).Count( x => li[x] == lo[x] + 1 ) == 1 ) {
            if( Range( 0, n[0] ).Count( x => li[x] + 1 == lo[x] ) == 1 ) {
                if( Range( 0, n[0] ).Count( x => li[x] == lo[x] ) == n[0] - 2 ) {
                    WriteLine( 1 );
                    return;
                }
            }
        }
        WriteLine( 0 );
        return;
    }
}
