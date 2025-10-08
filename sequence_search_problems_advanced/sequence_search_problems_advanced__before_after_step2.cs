// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();
        int xi = 0;
        int xx = int.MinValue;

        foreach( int i in Range( 0, n[0] - n[1] + 1 ) ) {
            int t = a.Skip( i ).Take( n[1] ).Sum();

            if( xx < t ) {
                xi = i;
                xx = t;
            }
        }
        WriteLine( xi + 1 );
        return;
    }
}
