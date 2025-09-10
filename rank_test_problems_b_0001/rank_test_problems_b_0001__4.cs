// 実行時間 20ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        string s = ReadLine();
        var c = System.StringComparison.Ordinal;

        for( int i = 0; i <= s.Length - 5; ) {
            string t = s.Substring( i, 5 );

            if( string.Compare( t, "LLLRB", c ) == 0 ) {
                i += 5;
                WriteLine( "rolling" );
            } else if( string.Compare( t, "DDRRA", c ) == 0 ) {
                i += 5;
                WriteLine( "upper" );
            } else if( string.Compare( t, "AAAAA", c ) == 0 ) {
                i += 5;
                WriteLine( "rush" );
            } else {
                i++;
            }
        }
        return;
    }
}
