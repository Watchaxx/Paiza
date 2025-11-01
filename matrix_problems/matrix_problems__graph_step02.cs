// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int s = 0;
        int[] d = new int[n];
        int[][] a = new int[n][];

        foreach( int i in Range( 0, n ) ) {
            a[i] = ReadLine().Split().Select( int.Parse ).ToArray();
            d[i] = a[i].Sum();
            if( d[i] != d[0] ) {
                WriteLine( "No" );
                return;
            }
        }
        WriteLine( "Yes" );
        return;
    }
}
