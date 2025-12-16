// 実行時間 40ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var w = ReadLine().Split().ToList();
        var a = ReadLine().Split().Select( int.Parse ).ToList();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Range( 0, n[1] ) ) {
            string[] q = ReadLine().Split();
            var sc = System.StringComparison.Ordinal;

            if( string.Compare( q[0], "push", sc ) == 0 ) {
                int c = a.Count;

                a.Add( int.Parse( q[2] ) );
                w.Add( q[1] );
                while( 0 < c ) {
                    int p = ( c - 1 ) / 2;

                    if( a[c] < a[p] ) {
                        Swap( w, a, c, p );
                        c = p;
                    } else {
                        break;
                    }
                }
            } else if( string.Compare( q[0], "pop", sc ) == 0 ) {
                int c = 0;

                WriteLine( w[0] );
                a[0] = a[a.Count - 1];
                w[0] = w[w.Count - 1];
                a.RemoveAt( a.Count - 1 );
                w.RemoveAt( w.Count - 1 );
                while( 2 * c + 1 < a.Count ) {
                    int l = 2 * c + 1;
                    int r = 2 * c + 2;

                    if( r < a.Count ) {
                        if( a[l] < a[c] && a[l] <= a[r] ) {
                            Swap( w, a, c, l );
                            c = l;
                            continue;
                        }
                        if( a[r] < a[c] ) {
                            Swap( w, a, c, r );
                            c = r;
                            continue;
                        }
                    } else if( a[l] < a[c] ) {
                        Swap( w, a, c, l );
                        c = l;
                        continue;
                    }
                    break;
                }
            }
        }
        WriteLine( string.Join( " ", w ) );
        Out.Flush();
        return;
    }

    static void Swap( List<string> w, List<int> l, int a, int b )
    {
        int ti = l[a];
        string ts = w[a];

        l[a] = l[b];
        w[a] = w[b];
        l[b] = ti;
        w[b] = ts;
        return;
    }
}
