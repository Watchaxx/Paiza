// 実行時間 290ms
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
        foreach( int i in Range( 2, n - 1 ).Where( x => p[x] ) ) {
            int j = 2 * i;

            while( j <= n ) {
                p[j] = false;
                j += i;
            }
        }
        WriteLine( p.Count( x => x ) );
        return;
    }
}
