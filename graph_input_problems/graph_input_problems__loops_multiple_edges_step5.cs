// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var l = new System.Collections.Generic.SortedSet<int>();

        foreach( int i in Range( 0, n[1] ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            if( t[0] == t[1] ) {
                l.Add( t[0] );
            }
        }
        WriteLine( l.Count );
        if( 0 < l.Count ) {
            WriteLine( string.Join( System.Environment.NewLine, l ) );
        }
        return;
    }
}
