// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int o = int.MaxValue;
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b = new int[n + 1];

        foreach( int i in Range( 0, n ) ) {
            b[i + 1] = b[i] + a[i];
        }
        foreach( int i in Range( 0, n - 1 ) ) {
            o = Min( o, Abs( b[i + 1] - ( b[n] - b[i + 1] ) ) );
        }
        WriteLine( o );
        return;
    }
}
