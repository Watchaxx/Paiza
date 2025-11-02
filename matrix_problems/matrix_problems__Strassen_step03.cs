// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] a1 = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] a2 = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b1 = ReadLine().Split().Select( int.Parse ).ToArray();
        int[] b2 = ReadLine().Split().Select( int.Parse ).ToArray();
        int m1 = ( a1[0] + a2[1] ) * ( b1[0] + b2[1] );
        int m2 = ( a2[0] + a2[1] ) * b1[0];
        int m3 = a1[0] * ( b1[1] - b2[1] );
        int m4 = a2[1] * ( b2[0] - b1[0] );
        int m5 = ( a1[0] + a1[1] ) * b2[1];
        int m6 = ( a2[0] - a1[0] ) * ( b1[0] + b1[1] );
        int m7 = ( a1[1] - a2[1] ) * ( b2[0] + b2[1] );

        WriteLine( $"{m1 + m4 - m5 + m7} {m3 + m5}" );
        WriteLine( $"{m2 + m4} {m1 - m2 + m3 + m6}" );
        return;
    }
}
