// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] l = new int[n + 1];
        int[] r = new int[n + 1];

        foreach( int i in Range( 0, n ) ) {
            l[i + 1] = Max( l[i], a[i] );
            r[i + 1] = Max( r[i], a[n - i - 1] );
        }
        foreach( int i in Range( 1, n - 2 ) ) {
            WriteLine( Min( l[i], r[n - i - 1] ) );
        }
        return;
    }
}
