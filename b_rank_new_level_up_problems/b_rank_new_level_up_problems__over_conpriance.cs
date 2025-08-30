// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        string s = ReadLine();
        string s1 = s.Length % 2 == 0 ? s.Substring( 0, s.Length / 2 ) : s.Substring( 0, s.Length / 2 + 1 );
        string s2 = s.Substring( s.Length / 2 );
        string x = string.Join( "", Repeat( 'x', s1.Length ) );

        foreach( int _ in Range( 0, n ) ) {
            string v = ReadLine();

            if( v.Length != s.Length ) {
                WriteLine( v );
                continue;
            }
            if( string.Compare( v, s, System.StringComparison.Ordinal ) == 0 ) {
                WriteLine( "banned" );
            } else if( v.StartsWith( s1 ) == true ) {
                WriteLine( $"{x}{v.Remove( 0, s1.Length )}" );
            } else if( v.EndsWith( s2 ) == true ) {
                WriteLine( $"{v.Substring( 0, v.Length - s2.Length )}{x}" );
            } else {
                WriteLine( v );
            }
        }
        return;
    }
}
