// 実行時間 30ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = 1;
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] d = Repeat( 1, n ).ToArray();

        foreach( int i in Range( 0, n ) ) {
            foreach( int j in Range( 0, i ) ) {
                if( a[j] < a[i] ) {
                    d[i] = Max( d[i], d[j] + 1 );
                }
            }
            o = Max( o, d[i] );
        }
        WriteLine( o );
        return;
    }
}
