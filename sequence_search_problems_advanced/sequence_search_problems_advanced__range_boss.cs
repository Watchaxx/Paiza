// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int m = 1;
        int o = 0;

        while( m < n - 1 ) {
            int c = 0;
            int l = m - 1;
            int r = m + 1;

            while( r < n && ( ( a[l] < a[m] && a[m] > a[r] ) || ( a[l] > a[m] && a[m] < a[r] ) ) ) {
                c++;
                l = m;
                m = r;
                r++;
            }
            o += c * ( c - 1 ) / 2 + c;
            if( c == 0 ) {
                m++;
            }
        }
        WriteLine( o );
        return;
    }
}
