// 実行時間 40ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        string[] sg = ReadLine().Split();
        int s = sg[0][0];
        int g = sg[1][0];
        int m = int.Parse( ReadLine() );
        int[] d = Repeat( -1, m + 2 ).ToArray();
        int[] p = Repeat( -1, m + 2 ).ToArray();
        string[] w = new string[m];
        var n = new Dictionary<int, (int, int)>( m );
        var e = new List<(int, int)>();
        var l = new List<string>();

        d[0] = 0;
        p[0] = 0;
        foreach( int i in Range( 0, m ) ) {
            string t = ReadLine();

            w[i] = t;
            n[i + 1] = (t[0], t.Last());
        }
        foreach( IEnumerable<int> q in Permutations( Range( 1, m ), 2 ).Where( x => n[x.First()].Item2 == n[x.Last()].Item1 ) ) {
            e.Add( (q.First(), q.Last()) );
        }
        foreach( int i in Range( 1, m ) ) {
            if( s == n[i].Item1 ) {
                e.Add( (0, i) );
            }
            if( g == n[i].Item2 ) {
                e.Add( (i, m + 1) );
            }
        }
        foreach( int _ in Range( 0, m + 1 ) ) {
            int[] f = new int[m + 2];

            d.CopyTo( f, 0 );
            foreach( var q in e.Where( x => d[x.Item1] != -1 && ( f[x.Item2] == -1 || d[x.Item1] + 1 < f[x.Item2] ) ) ) {
                f[q.Item2] = d[q.Item1] + 1;
                p[q.Item2] = q.Item1;
            }
            f.CopyTo( d, 0 );
        }
        if( d[m + 1] == -1 ) {
            WriteLine( "inf" );
            return;
        }

        int z = p[m + 1];

        l.Add( w[z - 1] );
        while( true ) {
            z = p[z];
            if( z == 0 ) {
                break;
            }
            l.Add( w[z - 1] );
        }
        l.Reverse();
        WriteLine( l.Count );
        WriteLine( string.Join( " ", l ) );
        return;
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
