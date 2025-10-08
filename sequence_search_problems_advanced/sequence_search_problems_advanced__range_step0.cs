// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int c = 0;
        int x = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).Append( -1 ).ToArray();

        foreach( int i in a ) {
            if( n[1] <= i ) {
                c++;
            } else {
                x = System.Math.Max( x, c );
                c = 0;
            }
        }
        WriteLine( x );
        return;
    }
}
