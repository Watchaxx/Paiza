using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var a = new System.Collections.Generic.SortedSet<int>();

        foreach( int i in Enumerable.Range( 0, n[0] ) ) {
            a.Add( int.Parse( ReadLine() ) );
        }
        foreach( int _ in Enumerable.Range( 0, n[1] ) ) {
            WriteLine( a.Contains( int.Parse( ReadLine() ) ) ? "YES" : "NO" );
        }
        return;
    }
}
