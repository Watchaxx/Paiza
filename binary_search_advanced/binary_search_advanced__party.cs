// 実行時間 770ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = new int[n];
        int[] l = new int[n];
        int[] sa = new int[n];
        int[] sl = new int[n];

        foreach( int i in Range( 0, n ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            a[i] = t[0];
            l[i] = t[1];
            sa[i] = t[0];
            sl[i] = t[1];
        }
        System.Array.Sort( sa );
        System.Array.Sort( sl );
        foreach( int i in Range( 0, n ) ) {
            int lt = BisectLeft( sl, a[i] );
            int rt = n - BisectRight( sa, l[i] );

            WriteLine( n - 1 - ( lt + rt ) );
        }
        return;
    }

    /// <summary>
    /// https://github.com/python/cpython/blob/3.13/Lib/bisect.py
    /// </summary>
    /// <param name="a">ソート済み配列</param>
    /// <param name="t">探す値(非負)</param>
    /// <returns>挿入する位置</returns>
    static int BisectLeft( int[] a, int t )
    {
        int l = 0;
        int r = a.Length;

        while( l < r ) {
            int m = ( l + r ) / 2;

            if( a[m] < t ) {
                l = m + 1;
            } else {
                r = m;
            }
        }
        return l;
    }

    static int BisectRight( int[] a, int t )
    {
        int l = 0;
        int r = a.Length;

        while( l < r ) {
            int m = ( l + r ) / 2;

            if( t < a[m] ) {
                r = m;
            } else {
                l = m + 1;
            }
        }
        return l;
    }
}
