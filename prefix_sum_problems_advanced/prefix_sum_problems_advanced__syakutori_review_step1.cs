// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int c = 0;
        int r = 0;
        int s = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int l in Range( 0, n[0] ) ) {
            while( r < n[0] && s + a[r] <= n[1] ) {
                s += a[r];
                r++;
            }
            c += r - l;
            if( l == r ) {
                r++;
            } else {
                s -= a[l];
            }
        }
        WriteLine( c );
        return;
    }
}
