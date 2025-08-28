// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nx = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();
        int[] a = new int[nx[0]];
        bool[] p = new bool[nx[1] + 1];

        foreach( int i in Range( 0, nx[0] ) ) {
            a[i] = int.Parse( ReadLine() );
        }
        p[0] = true;
        foreach( int i in Range( 0, nx[0] ) ) {
            for( int j = nx[1]; a[i] <= j; j-- ) {
                if( p[j - a[i]] == true ) {
                    p[j] = true;
                }
            }
        }
        WriteLine( p[nx[1]] ? "yes" : "no" );
        return;
    }
}
