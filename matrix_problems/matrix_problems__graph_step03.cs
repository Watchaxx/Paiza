// 実行時間 30ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] r = Range( 0, n ).ToArray();
        int[][] a = new int[n][];
        int[][] b = new int[n][];
        var p = new List<int[]>();

        foreach( int i in r ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        foreach( int i in r ) {
            b[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }
        Permutation( p, r.ToList(), 0 );
        foreach( int[] q in p ) {
            bool s = true;
            int[][] f = new int[n][];

            foreach( int i in r ) {
                f[i] = new int[n];
            }
            foreach( int i in r ) {
                foreach( int j in r ) {
                    f[q[i]][q[j]] = a[i][j];
                }
            }
            foreach( int _ in r.Where( x => f[x].SequenceEqual( b[x] ) != true ) ) {
                s = false;
                break;
            }
            if( s == true ) {
                WriteLine( "Yes" );
                return;
            }
        }
        WriteLine( "No" );
        return;
    }

    static void Permutation( List<int[]> p, List<int> t, int s )
    {
        for( int i = s; i < t.Count; i++ ) {
            Swap( t, i, s );
            Permutation( p, t, s + 1 );
            Swap( t, i, s );
        }
        if( s == t.Count - 1 ) {
            p.Add( t.ToArray() );
        }
        return;
    }

    static void Swap( List<int> l, int i, int j )
    {
        int t = l[i];
        l[i] = l[j];
        l[j] = t;
        return;
    }
}
