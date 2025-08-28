// 実行時間 20ms
using System;
using System.Linq;

internal class Program
{
    static void Main()
    {
        int[] nxayb = Console.ReadLine().Split().Select( int.Parse ).ToArray();
        int[] p = Enumerable.Repeat( 10000000, nxayb[0] + nxayb[3] ).ToArray();

        p[0] = 0;
        for( int i = 1; i < nxayb[0] + nxayb[3]; i++ ) {
            if( nxayb[1] <= i ) {
                p[i] = Math.Min( p[i], p[i - nxayb[1]] + nxayb[2] );
            }
            if( nxayb[3] <= i ) {
                p[i] = Math.Min( p[i], p[i - nxayb[3]] + nxayb[4] );
            }
        }
        for( int i = nxayb[0] + nxayb[3] - 2; 1 <= i; i-- ) {
            p[i] = Math.Min( p[i], p[i + 1] );
        }
        Console.WriteLine( p[nxayb[0]] );
        return;
    }
}
