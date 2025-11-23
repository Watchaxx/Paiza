// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var l = new System.Collections.Generic.List<int>();

        foreach( int i in Range( 0, n ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            if( t[i] == 1 ) {
                l.Add( i + 1 );
            }
        }
        WriteLine( l.Count );
        if( 0 < l.Count ) {
            WriteLine( string.Join( System.Environment.NewLine, l ) );
        }
        return;
    }
}
