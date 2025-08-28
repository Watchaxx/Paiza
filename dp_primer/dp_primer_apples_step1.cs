// 実行時間 20ms
using System;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nab = Console.ReadLine().Split().Select( int.Parse ).ToArray();
        int[] p = new int[nab[0] + 4];

        if( nab[0] == 1 ) {
            Console.WriteLine( nab[1] );
            return;
        }
        p[0] = 0;
        p[1] = nab[1];
        foreach( int i in Range( 2, nab[0] - 1 ) ) {
            p[i] = Math.Min( p[i - 2] + nab[1], nab[2] * (int)Math.Ceiling( i / 5m ) );
        }
        Console.WriteLine( p[nab[0]] );
        return;
    }
}
