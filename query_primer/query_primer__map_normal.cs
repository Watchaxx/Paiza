using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var d = new System.Collections.Generic.SortedDictionary<int, string>();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Enumerable.Range( 0, n[0] ) ) {
            string[] s = ReadLine().Split();

            d[int.Parse( s[0] )] = s[1];
        }
        foreach( int _ in Enumerable.Range( 0, n[1] ) ) {
            string[] s = ReadLine().Split();
            var c = System.StringComparison.Ordinal;

            if( string.Compare( s[0], "join", c ) == 0 ) {
                d[int.Parse( s[1] )] = s[2];
            } else if( string.Compare( s[0], "leave", c ) == 0 ) {
                d.Remove( int.Parse( s[1] ) );
            } else if( string.Compare( s[0], "call", c ) == 0 ) {
                WriteLine( d[int.Parse( s[1] )] );
            }
        }
        Out.Flush();
        return;
    }
}
