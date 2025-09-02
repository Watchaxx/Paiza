// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        int[] a = ReadLine().Trim().Split().Select( int.Parse ).ToArray();
        int[] s = ReadLine().Trim().Split().Select( int.Parse ).ToArray();

        foreach( int i in Range( a[1] - 1, a[0] ) ) {
            int t = n <= i ? i - n : i;

            if( s[t] == 1 ) {
                WriteLine( "No" );
                return;
            } else {
                s[t] = 1;
            }
        }
        WriteLine( "Yes" );
        WriteLine( string.Join( " ", s ) );
        return;
    }
}
