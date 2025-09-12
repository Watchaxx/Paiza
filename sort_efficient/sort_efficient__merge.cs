// 実行時間 580ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static int o = 0;

    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

        MergeSort( a, 0, n );
        WriteLine( string.Join( " ", a ) );
        WriteLine( o );
        return;
    }

    static void MergeSort( int[] a, int l, int r )
    {
        if( l + 1 < r ) {
            int m = ( l + r ) / 2;

            MergeSort( a, l, m );
            MergeSort( a, m, r );
            Merge( a, l, m, r );
        }
        return;
    }

    static void Merge( int[] a, int l, int m, int r )
    {
        int li = 0;
        int ri = 0;
        int nl = m - l;
        int nr = r - m;
        int[] al = new int[nl + 1];
        int[] ar = new int[nr + 1];

        foreach( int i in Range( 0, nl ) ) {
            al[i] = a[l + i];
        }
        foreach( int i in Range( 0, nr ) ) {
            ar[i] = a[m + i];
        }
        al[nl] = int.MaxValue;
        ar[nr] = int.MaxValue;
        for( int i = l; i < r; i++ ) {
            if( al[li] < ar[ri] ) {
                a[i] = al[li];
                li++;
            } else {
                a[i] = ar[ri];
                ri++;
                o++;
            }
        }
        return;
    }
}
