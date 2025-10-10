// 実行時間 100ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int l = 1;
        int r = n[0] + 1;

        while( 1 < r - l ) {
            int c = 0;
            int m = ( r + l ) / 2;
            int s = 0;

            foreach( int i in Range( 0, n[0] ) ) {
                c++;
                if( m <= c ) {
                    c = 0;
                    s++;
                }
                if( i != n[0] - 1 && a[i] + 1 != a[i + 1] ) {
                    c = 0;
                }
            }
            if( n[1] <= s ) {
                l = m;
            } else {
                r = m;
            }
        }
        WriteLine( l );
        return;
    }
}
