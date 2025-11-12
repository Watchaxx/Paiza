// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int k = int.Parse( ReadLine() );
        int[] a = new int[4];

        foreach( int i in Range( 0, 4 ) ) {
            a[i] = int.Parse( ReadLine() );
        }
        foreach( int i in Range( 1, 4 ) ) {
            foreach( int[] _ in Combinations( a, i ).Where( x => x.Sum() == k ) ) {
                WriteLine( "Yes" );
                return;
            }
        }
        WriteLine( "No" );
        return;
    }

    /// <summary>
    /// https://qiita.com/gushwell/items/74a96f56ccb64db3660c
    /// </summary>
    /// <param name="items">元データ</param>
    /// <param name="n">組み合わせる数</param>
    /// <returns>組み合わせ</returns>
    static IEnumerable<T[]> Combinations<T>( IEnumerable<T> items, int n )
    {
        if( n == 1 ) {
            foreach( T i in items ) {
                yield return new T[] { i };
            }
            yield break;
        }
        foreach( T i in items ) {
            T[] l = new T[] { i };
            IEnumerable<T> u = items.SkipWhile( x => x.Equals( i ) != true ).Skip( 1 );

            foreach( T[] j in Combinations( u, n - 1 ) ) {
                yield return l.Concat( j ).ToArray();
            }
        }
    }
}
