// 実行時間 530ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = int.MaxValue;
        int[] v = new int[n];
        int[][] a = new int[n][];

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
            v[i] = i;
        }
        foreach( IEnumerable<int> q in Permutations( v ) ) {
            int c = 0;

            foreach( int i in Range( 0, n ) ) {
                c += a[q.ElementAt( i )][q.ElementAt( ( i + 1 ) % n )];
            }
            o = new[] { o, c }.Min();
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
