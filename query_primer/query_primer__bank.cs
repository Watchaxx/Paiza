using System.Collections.Generic;
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var d = new Dictionary<string, int[]>( n[0] );

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Enumerable.Range( 0, n[0] ) ) {
            string[] s = ReadLine().Split();

            d[s[0]] = s.Skip( 1 ).Select( int.Parse ).ToArray();
        }
        foreach( int _ in Enumerable.Range( 0, n[1] ) ) {
            string[] s = ReadLine().Split();

            if( d[s[0]][0] == int.Parse( s[1] ) ) {
                d[s[0]][1] -= int.Parse( s[2] );
            }
        }
        foreach( KeyValuePair<string, int[]> p in d ) {
            WriteLine( $"{p.Key} {p.Value[1]}" );
        }
        Out.Flush();
        return;
    }
}
