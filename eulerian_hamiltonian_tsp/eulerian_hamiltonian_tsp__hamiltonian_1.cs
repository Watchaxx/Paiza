// 実行時間 230ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );

        WriteLine( string.Join( System.Environment.NewLine,
            Permutations( Range( 1, n ) ).Select( x => string.Join( " ", x ) ) ) );
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
