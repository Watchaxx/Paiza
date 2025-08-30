// 実行時間 20ms
using System.Linq;
using static System.Console;

internal class Program
{
    static void Main()
    {
        int[] yxh = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] l = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] m = ReadLine().Split().Select( int.Parse ).ToArray();

        if( yxh[2] <= l[0] ) {
            if( System.Math.Max( yxh[0], yxh[1] ) <= l[1] ) {
                WriteLine( m[0] );
            } else if( yxh[0] + yxh[1] <= l[2] ) {
                WriteLine( m[1] );
            } else {
                WriteLine( m[2] );
            }
        } else {
            if( yxh.Max() <= l[3] ) {
                WriteLine( m[3] );
            } else if( yxh.Sum() <= l[4] ) {
                WriteLine( m[4] );
            } else {
                WriteLine( yxh[0] * yxh[1] * yxh[2] * m[5] );
            }
        }
        return;
    }
}
