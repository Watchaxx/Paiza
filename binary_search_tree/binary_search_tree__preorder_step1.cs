// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

        Func( n, t, 0 );
        return;
    }

    static void Func( int n, int[] t, int i )
    {
        if( n <= i ) {
            return;
        }
        WriteLine( t[i] );
        Func( n, t, 2 * i + 1 );
        Func( n, t, 2 * i + 2 );
        return;
    }
}
