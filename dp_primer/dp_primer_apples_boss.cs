// 実行時間 20ms
using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int[] nxaybzc = Console.ReadLine().Split().Select( int.Parse ).ToArray();
        int[] p = Enumerable.Repeat( 10000000, nxaybzc[0] + nxaybzc[5] ).ToArray();

        p[0] = 0;
        for( int i = 1; i < nxaybzc[0] + nxaybzc[5]; i++ ) {
            if( nxaybzc[1] <= i ) {
                p[i] = Math.Min( p[i], p[i - nxaybzc[1]] + nxaybzc[2] );
            }
            if( nxaybzc[3] <= i ) {
                p[i] = Math.Min( p[i], p[i - nxaybzc[3]] + nxaybzc[4] );
            }
            if( nxaybzc[5] <= i ) {
                p[i] = Math.Min( p[i], p[i - nxaybzc[5]] + nxaybzc[6] );
            }
        }
        for( int i = nxaybzc[0] + nxaybzc[5] - 2; 1 <= i; i-- ) {
            p[i] = Math.Min( p[i], p[i + 1] );
        }
        Console.WriteLine( p[nxaybzc[0]] );
        return;
    }
}
