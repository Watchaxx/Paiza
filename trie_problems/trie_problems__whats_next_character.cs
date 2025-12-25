// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        string[] s = new string[n];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int i in Range( 0, n ) ) {
            s[i] = ReadLine();
        }

        string p = ReadLine();

        foreach( int i in Range( 0, n ) ) {
            WriteLine( !s[i].StartsWith( p )
                ? '/' : string.Compare( s[i], p, System.StringComparison.Ordinal ) == 0
                ? '#' : s[i][p.Length] );
        }
        Out.Flush();
        return;
    }
}
