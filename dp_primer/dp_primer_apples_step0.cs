// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] nab = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] p = new int[nab[0] + 1];

        p[0] = 0;
        p[1] = nab[1];
        foreach( int i in Range( 2, nab[0] - 1 ) ) {
            p[i] = System.Math.Min( p[i - 1] + nab[1], p[i - 2] + nab[2] );
        }
        WriteLine( p[nab[0]] );
        return;
    }
}
