// 実行時間 240ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Range( 0, int.Parse( ReadLine() ) ) ) {
            WriteLine( System.Convert.ToString( long.Parse( ReadLine() ), 2 ) );
        }
        Out.Flush();
        return;
    }
}
