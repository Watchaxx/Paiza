// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        for( int _ = 0; _ < 5; _++ ) {
            string s = ReadLine();
            var c = System.StringComparison.Ordinal;

            if( string.Compare( s, "OOOOO", c ) == 0 ) {
                WriteLine( 'O' );
                return;
            } else if( string.Compare( s, "XXXXX", c ) == 0 ) {
                WriteLine( 'X' );
                return;
            }
        }
        WriteLine( 'D' );
        return;
    }
}
