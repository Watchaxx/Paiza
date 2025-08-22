using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var a = new System.Collections.Generic.LinkedList<string>();

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Enumerable.Range( 0, n[0] ) ) {
            a.AddLast( ReadLine() );
        }
        foreach( int _ in Enumerable.Range( 0, n[1] ) ) {
            string s = ReadLine();
            var c = System.StringComparison.Ordinal;

            if( string.Compare( s, "pop", c ) == 0 && 0 < a.Count ) {
                a.RemoveFirst();
            } else if( string.Compare( s, "show", c ) == 0 ) {
                WriteLine( string.Join( System.Environment.NewLine, a ) );
            }
        }
        Out.Flush();
        return;
    }
}
