// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() ) - 1;
        sbyte[] t = ReadLine().Split().Select( sbyte.Parse ).ToArray();

        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            bool b = false;
            int d = int.Parse( ReadLine() );
            int m = 0;

            while( m < 500 ) {
                if( n == d ) {
                    b = true;
                    break;
                } else if( d < 0 || n < d ) {
                    break;
                }
                d += t[d];
                m++;
            }
            WriteLine( b ? "Yes" : "No" );
        }
        return;
    }
}
