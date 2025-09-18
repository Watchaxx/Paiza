// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Lst = System.Collections.Generic.List<int>;

internal class Program
{
    static int[] l;
    static int[] p;
    static Lst[] g;

    static void Main()
    {
        int[] ntscd = ReadLine().Split().Select( int.Parse ).ToArray();

        ntscd[1]--;
        ntscd[2]--;
        l = Repeat( -1, ntscd[0] ).ToArray();
        l[ntscd[1]] = 0;
        p = new int[ntscd[0]];
        p[ntscd[1]] = -1;
        g = new Lst[ntscd[0]];
        foreach( int i in Range( 0, ntscd[0] ) ) {
            g[i] = new Lst( ntscd[0] );
        }
        foreach( int _ in Range( 0, ntscd[0] - 1 ) ) {
            int[] a = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            g[a[0]].Add( a[1] );
            g[a[1]].Add( a[0] );
        }
        GetLen( ntscd[1] );
        if( l[ntscd[2]] <= ntscd[3] ) {
            foreach( int i in Range( 0, ntscd[0] ).Where( i => l[i] == l[ntscd[2]] - ntscd[3] + ntscd[4] ) ) {
                WriteLine( i + 1 );
            }
        } else {
            int h = ntscd[2];

            foreach( int _ in Range( 0, ntscd[3] ) ) {
                h = p[h];
            }
            foreach( int i in Range( 0, ntscd[0] ).Where( i => l[i] == l[ntscd[2]] - ntscd[3] + ntscd[4] ) ) {
                int z = i;

                foreach( int _ in Range( 0, ntscd[4] ) ) {
                    z = p[z];
                }
                if( z == h ) {
                    WriteLine( i + 1 );
                }
            }
        }
        return;
    }

    static void GetLen( int c )
    {
        foreach( int i in g[c].Where( i => l[i] == -1 ) ) {
            l[i] = l[c] + 1;
            p[i] = c;
            GetLen( i );
        }
        return;
    }
}
