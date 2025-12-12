// 実行時間 130ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );

        if( ( n & 1 ) == 0 || n < 5 ) {
            WriteLine( "No" );
            return;
        }
        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        WriteLine( "Yes" );
        WriteLine( n );
        foreach( int i in Range( 0, n - 1 ) ) {
            WriteLine( $"{i + 1} {i + 2}" );
        }
        WriteLine( $"{n} 1" );
        WriteLine( n * ( n - 1 ) / 2 - n );
        foreach( int i in Range( 0, n ) ) {
            for( int j = i + 2; j < n; j++ ) {
                if( !( i == 0 && j == n - 1 ) ) {
                    WriteLine( $"{i + 1} {j + 1}" );
                }
            }
        }
        Out.Flush();
        return;
    }
}
