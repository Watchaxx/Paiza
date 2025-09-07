// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] hwn = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] o = new int[hwn[2]];
        int[][] t = new int[hwn[0]][];

        foreach( int i in Range( 0, hwn[0] ) ) {
            t[i] = ReadLine().Split().Select( int.Parse ).ToArray();
        }

        int c = 0;
        int l = int.Parse( ReadLine() );

        foreach( int _ in Range( 0, l ) ) {
            int[] ab = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            if( t[ab[0]][ab[1]] == t[ab[2]][ab[3]] ) {
                o[c] += 2;
            } else {
                c++;
                if( hwn[2] <= c ) {
                    c = 0;
                }
            }
        }
        WriteLine( string.Join( System.Environment.NewLine, o ) );
        return;
    }
}
