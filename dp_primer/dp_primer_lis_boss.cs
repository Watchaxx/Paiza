// 実行時間 190ms
using System;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( Console.ReadLine() );
        int o = 1;
        int[] a = new int[n];
        int[] p = new int[n];

        foreach( int i in Range( 0, n ) ) {
            a[i] = int.Parse( Console.ReadLine() );
        }
        p[0] = 1;
        foreach( int i in Range( 1, n - 1 ) ) {
            p[i] = 1;
            foreach( int j in Range( 0, i ) ) {
                if( a[i] < a[j] ) {
                    p[i] = Math.Max( p[i], p[j] + 1 );
                    o = Math.Max( o, p[i] );
                }
            }
        }
        Console.WriteLine( o );
        return;
    }
}
