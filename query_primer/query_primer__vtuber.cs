using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var d = new Dictionary<string, int>( n );
        var s = new SortedSet<string>();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Enumerable.Range( 0, n ) ) {
            string[] t = ReadLine().Split();
            var c = System.StringComparison.Ordinal;

            if( string.Compare( t[1], "give", c ) == 0 ) {
                d[t[0]] = d.TryGetValue( t[0], out int v ) ? v + int.Parse( t[2] ) : int.Parse( t[2] );
            } else if( string.Compare( t[1], "join", c ) == 0 ) {
                s.Add( t[0] );
            }
        }
        foreach( KeyValuePair<string, int> p in d.OrderByDescending( x => x.Value ).ThenByDescending( x => x.Key ) ) {
            WriteLine( p.Key );
        }
        WriteLine( string.Join( System.Environment.NewLine, s ) );
        Out.Flush();
        return;
    }
}
