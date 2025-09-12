// 実行時間 410ms
using System.Linq;
using static System.Console;

internal class Program
{
    static int o = 0;

    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

        QuickSort( a, 0, n );
        WriteLine( string.Join( " ", a ) );
        WriteLine( o );
        return;
    }

    static void QuickSort( int[] a, int l, int r )
    {
        if( r <= l + 1 ) {
            return;
        }

        int c = l;
        int p = a[r - 1];
        int t = 0;

        for( int i = l; i <= r - 2; i++ ) {
            if( a[i] < p ) {
                t = a[c];
                a[c] = a[i];
                a[i] = t;
                c++;
                o++;
            }
        }
        t = a[c];
        a[c] = a[r - 1];
        a[r - 1] = t;
        QuickSort( a, l, c );
        QuickSort( a, c + 1, r );
        return;
    }
}
