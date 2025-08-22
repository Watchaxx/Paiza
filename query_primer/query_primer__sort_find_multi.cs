using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int o = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var a = new System.Collections.Generic.List<int>( n[0] + n[1] ) { n[2] };

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Enumerable.Range( 0, n[0] ) ) {
            a.Add( int.Parse( ReadLine() ) );
        }
        o = a.OrderBy( x => x ).ToList().IndexOf( n[2] ) + 1;
        foreach( int _ in Enumerable.Range( 0, n[1] ) ) {
            string[] s = ReadLine().Split();
            var c = System.StringComparison.Ordinal;

            if( string.Compare( s[0], "join", c ) == 0 && int.Parse( s[1] ) < n[2] ) {
                o++;
            } else if( string.Compare( s[0], "sorting", c ) == 0 ) {
                WriteLine( o );
            }
        }
        Out.Flush();
        return;
    }
}
