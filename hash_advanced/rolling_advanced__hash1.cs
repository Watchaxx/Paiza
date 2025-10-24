// 実行時間 50ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int l = int.Parse( ReadLine() );
        string s = ReadLine();
        ulong h = 0ul;

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, l ) ) {
            h = ( h * 100000007ul + s[i] ) % 1000000007ul;
            WriteLine( h );
        }
        Out.Flush();
        return;
    }
}
