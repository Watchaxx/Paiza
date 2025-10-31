// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int i in Range( 0, n ) ) {
            a[i] -= b[i];
        }
        WriteLine( string.Join( " ", a ) );
        return;
    }
}
