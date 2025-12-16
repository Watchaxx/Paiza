// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var a = ReadLine().Split().Select( int.Parse ).ToList();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Range( 0, n[1] ) ) {
            string[] q = ReadLine().Split();
            var sc = System.StringComparison.Ordinal;

            if( string.Compare( q[0], "push", sc ) == 0 ) {
                int c = a.Count;

                a.Add( int.Parse( q[1] ) );
                while( 0 < c ) {
                    int p = ( c - 1 ) / 2;

                    if( a[c] < a[p] ) {
                        Swap( a, c, p );
                        c = p;
                    } else {
                        break;
                    }
                }
            } else if( string.Compare( q[0], "pop", sc ) == 0 ) {
                int c = 0;

                WriteLine( a[0] );
                a[0] = a[a.Count - 1];
                a.RemoveAt( a.Count - 1 );
                while( c < a.Count ) {
                    int f = 0;
                    int m = a[c];
                    int l = 2 * c + 1;
                    int r = 2 * c + 2;

                    if( l < a.Count && a[l] <= m ) {
                        f = 1;
                        m = a[l];
                    }
                    if( r < a.Count && a[r] < m ) {
                        f = 2;
                        m = a[r];
                    }
                    if( f == 0 ) {
                        break;
                    } else if( f == 1 ) {
                        Swap( a, c, l );
                        c = l;
                    } else if( f == 2 ) {
                        Swap( a, c, r );
                        c = r;
                    }
                }
            }
        }
        WriteLine( string.Join( " ", a ) );
        Out.Flush();
        return;
    }

    static void Swap( Lst l, int a, int b )
    {
        int t = l[a];
        l[a] = l[b];
        l[b] = t;
        return;
    }
}
