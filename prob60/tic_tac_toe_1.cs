// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        string s = ReadLine();
        var c = System.StringComparison.Ordinal;

        if( string.Compare( s, "OOOOO", c ) == 0 ) {
            WriteLine( 'O' );
        } else if( string.Compare( s, "XXXXX", c ) == 0 ) {
            WriteLine( 'X' );
        } else {
            WriteLine( 'D' );
        }
        return;
    }
}
