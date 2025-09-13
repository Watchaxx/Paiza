// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] na = ReadLine().Split().Select( int.Parse ).ToArray();
        var l = new System.Collections.Generic.List<int>();

        foreach( int i in Range( 1, 1000 ) ) {
            if( ( na[0] % Gcd( na[1], i ) != 0 ) && na[1] != i ) {
                l.Add( i );
            }
        }
        WriteLine( 0 < l.Count ? string.Join( System.Environment.NewLine, l.OrderBy( x => x ) ) : "-1" );
        return;
    }

    static int Gcd( int a, int b )
    {
        return b == 0 ? a : Gcd( b, a % b );
    }
}
