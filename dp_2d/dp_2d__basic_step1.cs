// 実行時間 50ms
using static System.Console;
using static System.Linq.Enumerable;
using static System.Math;

class Program
{
    static void Main()
    {
        int[] hwm = ReadLine().Split().Select( int.Parse ).ToArray();
        int[,] c = new int[hwm[0], hwm[1]];
        int[,] d = new int[hwm[0], hwm[1]];

        foreach( int _ in Range( 0, hwm[2] ) ) {
            int[] t = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();

            c[t[0], t[1]] = 1;
        }
        foreach( int i in Range( 0, hwm[0] ) ) {
            foreach( int j in Range( 0, hwm[1] ) ) {
                if( 0 < i ) {
                    d[i, j] = Max( d[i, j], d[i - 1, j] + c[i, j] );
                }
                if( 0 < j ) {
                    d[i, j] = Max( d[i, j], d[i, j - 1] + c[i, j] );
                }
            }
        }
        WriteLine( d[hwm[0] - 1, hwm[1] - 1] );
        return;
    }
}
