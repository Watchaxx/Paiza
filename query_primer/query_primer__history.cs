using System.Linq;
using static System.Console;
using Tpl = System.Tuple<int, string>;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        Tpl[] t = new Tpl[n[1]];

        SetOut( new System.IO.StreamWriter( OpenStandardOutput() ) { AutoFlush = false } );
        foreach( int _ in Enumerable.Range( 0, n[0] ) ) {
            ReadLine();
        }
        foreach( int i in Enumerable.Range( 0, n[1] ) ) {
            string[] s = ReadLine().Split();

            t[i] = new Tpl( int.Parse( s[0] ), s[1] );
        }
        foreach( Tpl p in t.OrderBy( x => x.Item1 ).ThenBy( x => x.Item2 ) ) {
            WriteLine( p.Item2 );
        }
        Out.Flush();
        return;
    }
}
