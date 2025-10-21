// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 0;
        int[] d = new int[n];
        int[] h = Repeat( -1, 10010 ).ToArray();

        foreach( int i in Range( 0, n ) ) {
            d[i] = int.Parse( ReadLine() );
        }
        foreach( int i in Range( 0, n ) ) {
            int t = d[i] % 10000;

            if( h[t] == -1 ) {
                h[t] = t;
            } else {
                o++;
            }
        }
        WriteLine( o );
        o = 0;
        h = Repeat( -1, 10010 ).ToArray();
        foreach( int i in Range( 0, n ) ) {
            int t = d[i] / 10000;

            if( h[t] == -1 ) {
                h[t] = t;
            } else {
                o++;
            }
        }
        WriteLine( o );
        return;
    }
}
