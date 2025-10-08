// 実行時間 160ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Split().Select( int.Parse ).OrderBy( x => x ).ToArray();

        if( 1 < a[0] ) {
            WriteLine( "No" );
            return;
        }
        foreach( int _ in Range( 0, n - 1 ).Where( x => a[x] + 1 < a[x + 1] ) ) {
            WriteLine( "No" );
            return;
        }
        WriteLine( "Yes" );
        return;
    }
}
