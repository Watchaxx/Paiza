// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var a = new System.Collections.Generic.List<string>( ReadLine().Split() );
        string[] b = ReadLine().Split();
        int[] x = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int i in Range( 0, n[1] ) ) {
            a.Insert( x[i] - 1, b[i] );
        }
        WriteLine( string.Join( System.Environment.NewLine, a ) );
        return;
    }
}
