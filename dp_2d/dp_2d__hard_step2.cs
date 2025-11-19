// 実行時間 260ms
using System;
using System.Collections.Generic;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = Console.ReadLine().Split().Select( int.Parse ).ToArray();
        long[] a = Console.ReadLine().Split().Select( long.Parse ).ToArray();
        long[] b = a.OrderBy( x => x ).ToArray();
        long[] d = Repeat( long.MinValue, n[0] ).ToArray();

        foreach( int i in PyRng( n[0] ) ) {
            int t = Array.IndexOf( b, a[i] );

            d[t] = 1;
            foreach( int j in PyRng( n[0] ).Where( x => x != t && Math.Abs( a[i] - b[x] ) <= n[1] ) ) {
                d[t] = Math.Max( d[t], d[j] + 1 );
            }
        }
        Console.WriteLine( d.Max() );
        return;
    }

    static IEnumerable<int> PyRng( int z ) { return Range( 0, z ); }
}
