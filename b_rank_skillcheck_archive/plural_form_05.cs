// 実行時間 10ms
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        string[] p1 = { "s", "sh", "ch", "o", "x" };
        string[] p2 = { "ay", "iy", "uy", "ey", "oy" };
        var c = System.StringComparison.Ordinal;

        for( int _ = 0; _ < n; _++ ) {
            string a = ReadLine();

            if( EndsWith( a, p1 ) == true ) {
                WriteLine( $"{a}es" );
            } else if( a.EndsWith( "f", c ) ) {
                WriteLine( $"{a.Substring( 0, a.Length - 1 )}ves" );
            } else if( a.EndsWith( "fe", c ) ) {
                WriteLine( $"{a.Substring( 0, a.Length - 2 )}ves" );
            } else if( a.EndsWith( "y", c ) ) {
                if( EndsWith( a, p2 ) != true ) {
                    WriteLine( $"{a.Substring( 0, a.Length - 1 )}ies" );
                } else {
                    WriteLine( $"{a}s" );
                }
            } else {
                WriteLine( $"{a}s" );
            }
        }
        return;
    }

    static bool EndsWith( string s, string[] p )
    {
        var c = System.StringComparison.Ordinal;

        foreach( string t in p ) {
            if( s.EndsWith( t, c ) == true ) {
                return true;
            }
        }
        return false;
    }
}
