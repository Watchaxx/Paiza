// 実行時間 180ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] v = new int[n[0]];
        bool[][] g = new bool[n[0]][];

        foreach( int i in Range( 0, n[0] ) ) {
            g[i] = new bool[n[0]];
            v[i] = i;
        }
        foreach( int _ in Range( 0, n[1] ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]][a[1]] = true;
        }
        foreach( IEnumerable<int> p in Permutations( v ) ) {
            bool b = true;
            int[] q = p.ToArray();

            if( q[0] != 0 ) {
                continue;
            }
            foreach( int _ in Range( 0, n[0] ).Where( x => g[q[x]][q[( x + 1 ) % n[0]]] != true ) ) {
                b = false;
                break;
            }
            if( b == true ) {
                o++;
            }
        }
        WriteLine( o );
        return;
    }

    static IEnumerable<IEnumerable<T>> Permutations<T>( IEnumerable<T> items )
    {
        return Permutations( items, items.Count() );
    }

    static IEnumerable<IEnumerable<T>> Permutations<T>( IEnumerable<T> items, int n )
    {
        if( n == 1 ) {
            foreach( T i in items ) {
                yield return new T[] { i };
            }
        } else {
            foreach( T i in items ) {
                IEnumerable<T> u = items.Where( x => x.Equals( i ) != true );

                foreach( IEnumerable<T> j in Permutations( u, n - 1 ) ) {
                    yield return new T[] { i }.Concat( j );
                }
            }
        }
    }
}
