// 実行時間 20ms
using System.Linq;
using static System.Console;
using Lst = System.Collections.Generic.List<int>;

class Program
{
    static void Main()
    {
        int c = 0;
        var a = ReadLine().Split().Select( int.Parse ).ToList();

        a[0] = a[a.Count - 1];
        a.RemoveAt( a.Count - 1 );
        while( c < a.Count ) {
            int cl = 2 * c + 1;
            int cr = 2 * c + 2;
            int f = 0;
            int m = a[c];

            if( cl < a.Count && a[cl] <= m ) {
                f = 1;
                m = a[cl];
            }
            if( cr < a.Count && a[cr] < m ) {
                f = 2;
                m = a[cr];
            }
            if( f == 0 ) {
                break;
            } else if( f == 1 ) {
                Swap( a, c, cl );
                c = cl;
            } else if( f == 2 ) {
                Swap( a, c, cr );
                c = cr;
            }
        }
        WriteLine( string.Join( " ", a ) );
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
