// 実行時間 670ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int i in Range( 0, 1 << n[0] ) ) {
            int s = 0;

            foreach( int j in Range( 0, n[0] ).Reverse().Where( x => ( ( 1 << x ) & i ) != 0 ) ) {
                s += a[j];
            }
            if( s == n[1] ) {
                WriteLine( "Yes" );
                return;
            }
        }
        WriteLine( "No" );
        return;
    }
}
