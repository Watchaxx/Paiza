// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        string s = ReadLine();
        int m = int.Parse( s.Split()[1] );

        WriteLine( s );
        for( int _ = 0; _ < m; _++ ) {
            WriteLine( ReadLine() );
        }
        return;
    }
}
