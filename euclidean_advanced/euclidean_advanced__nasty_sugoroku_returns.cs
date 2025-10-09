// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        bool b = true;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int m = Gcd( n[1], n[2] );

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 1, 1000 ).Where( x => n[0] % Gcd( x, m ) != 0 ) ) {
            b = false;
            WriteLine( i );
        }
        if( b == true ) {
            WriteLine( -1 );
        }
        Out.Flush();
        return;
    }

    static int Gcd( int a, int b )
    {
        return b == 0 ? a : Gcd( b, a % b );
    }
}
