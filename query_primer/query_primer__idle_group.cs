using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var s = new System.Collections.Generic.SortedSet<string>();

        foreach( int _ in Enumerable.Range( 0, n[0] ) ) {
            s.Add( ReadLine() );
        }
        foreach( int _ in Enumerable.Range( 0, n[1] ) ) {
            string[] t = ReadLine().Split();
            var c = System.StringComparison.Ordinal;

            if( string.Compare( t[0], "join", c ) == 0 ) {
                s.Add( t[1] );
            } else if( string.Compare( t[0], "leave", c ) == 0 ) {
                s.Remove( t[1] );
            } else if( string.Compare( t[0], "handshake", c ) == 0 ) {
                if( 0 < s.Count ) {
                    WriteLine( string.Join( System.Environment.NewLine, s ) );
                }
            }
        }
        return;
    }
}
