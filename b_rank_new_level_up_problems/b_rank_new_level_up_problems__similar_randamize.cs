// 実行時間 20ms
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int p = 1;
        int[] x = ReadLine().Split( ' ' ).Select( int.Parse ).ToArray();

        foreach( int _ in Enumerable.Range( 0, x[2] ) ) {
            p *= x[0];
            p %= x[1];
            o += p;
            o %= x[1];
            WriteLine( o );
        }
        return;
    }
}
