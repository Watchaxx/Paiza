// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();

        foreach( int i in Range( 0, n[0] / n[2] + 1 ) ) {
            int c = n[0] - n[2] * i;

            if( ( c % n[3] == 0 ) || ( ( c - n[1] ) % n[3] == 0 && 0 <= c - n[1] ) ) {
                WriteLine( "Yes" );
                return;
            }
        }
        WriteLine( "No" );
        return;
    }
}
