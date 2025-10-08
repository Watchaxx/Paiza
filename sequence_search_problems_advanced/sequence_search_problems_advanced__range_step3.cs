// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).Append( -1 ).ToArray();
        int p = a[0];
        int s = 1;
        int x = 0;

        foreach( int i in a.Skip( 1 ) ) {
            if( i == p ) {
                s++;
            } else {
                x = System.Math.Max( x, s );
                p = i;
                s = 1;
            }
        }
        WriteLine( x );
        return;
    }
}
