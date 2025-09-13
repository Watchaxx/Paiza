// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        bool[] p = Repeat( true, n + 1 ).ToArray();

        p[0] = false;
        p[1] = false;
        for( int i = 2; i <= n; i++ ) {
            if( p[i] == true ) {
                for( int j = 2 * i; j <= n; j += i ) {
                    p[j] = false;
                }
            }
        }
        WriteLine( p[n] ? "YES" : "NO" );
        return;
    }
}
