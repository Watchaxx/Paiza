// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        WriteLine( n );
        foreach( int _ in Range( 0, n ) ) {
            WriteLine( string.Join( " ", ReadLine().Split().Select( double.Parse ) ) );
        }
        Out.Flush();
        return;
    }
}
