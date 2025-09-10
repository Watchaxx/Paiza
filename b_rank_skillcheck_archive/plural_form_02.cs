// 実行時間 20ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );

        for( int _ = 0; _ < n; _++ ) {
            string a = ReadLine();

            if( a.EndsWith( "s" ) || a.EndsWith( "sh" ) || a.EndsWith( "ch" ) || a.EndsWith( "o" ) || a.EndsWith( "x" ) ) {
                WriteLine( $"{a}es" );
            } else {
                WriteLine( $"{a}s" );
            }
        }
        return;
    }
}
