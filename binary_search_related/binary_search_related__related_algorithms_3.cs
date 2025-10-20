// 実行時間 350ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;
using Lst = System.Collections.Generic.List<System.Tuple<int, int, int>>;
using Tpl = System.Tuple<int, int, int>;

internal class Program
{
    class Seg
    {
        int N = 1;
        int[] Node;

        internal Seg( int i )
        {
            while( N < i ) {
                N *= 2;
            }
            Node = Repeat( int.MaxValue, 2 * N - 1 ).ToArray();
        }

        internal int Query( int a, int b, int k = 0, int l = 0, int r = -1 )
        {
            if( r < 0 ) {
                r = N;
            }
            if( r <= a || b <= l ) {
                return int.MaxValue;
            }
            if( a <= l && r <= b ) {
                return Node[k];
            }

            int ll = Query( a, b, 2 * k + 1, l, ( l + r ) / 2 );
            int rr = Query( a, b, 2 * k + 2, ( l + r ) / 2, r );
            return Min( ll, rr );
        }

        internal void Update( int a, int b )
        {
            a += N - 1;
            Node[a] = b;
            while( 0 < a ) {
                a = ( a - 1 ) / 2;
                Node[a] = Min( Node[2 * a + 1], Node[2 * a + 2] );
            }
            return;
        }
    }

    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] s = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] c = new int[n[1]];
        int[] d = new int[n[1]];
        int[] a = new int[n[2]];
        int[] b = new int[n[2]];
        int[] o = new int[n[2]];
        int[] x = new int[n[2]];
        int cnt = n[0];
        Lst[] v = new Lst[n[1] + 1];

        foreach( int i in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            c[i] = t[0];
            d[i] = t[1];
            v[i] = new Lst();
        }
        v[n[1]] = new Lst();
        foreach( int i in Range( 0, n[2] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            a[i] = t[0];
            b[i] = t[1];
            x[i] = t[2];
            v[n[1] / 2].Add( new Tpl( -1, n[1] + 1, i ) );
        }
        while( 0 < cnt ) {
            Seg st = new Seg( n[0] );
            Lst[] u = new Lst[n[1] + 1];

            cnt = 0;
            foreach( int i in Range( 0, n[1] + 1 ) ) {
                u[i] = new Lst();
            }
            foreach( int i in Range( 0, n[0] ) ) {
                st.Update( i, s[i] );
            }
            foreach( int i in Range( 0, n[1] + 1 ) ) {
                foreach( Tpl t in v[i] ) {
                    int l = t.Item1;
                    int r = t.Item2;
                    int j = t.Item3;

                    if( st.Query( a[j], b[j] ) <= x[j] ) {
                        r = i;
                    } else {
                        l = i;
                    }
                    if( 1 < r - l ) {
                        cnt++;
                        u[( l + r ) / 2].Add( new Tpl( l, r, j ) );
                    } else {
                        o[j] = r == n[1] + 1 ? -1 : r;
                    }
                }
                if( i < n[1] ) {
                    st.Update( c[i] - 1, st.Query( c[i] - 1, c[i] ) - d[i] );
                }
            }
            foreach( int i in Range( 0, n[1] + 1 ) ) {
                v[i] = new Lst();
                v[i].AddRange( u[i] );
            }
        }
        WriteLine( string.Join( System.Environment.NewLine, o ) );
        return;
    }
}
