// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int c = 0;
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        int[][] to = new int[n[0]][];
        var s = new System.Collections.Generic.Stack<int>();

        foreach( int i in Range( 0, n[0] ) ) {
            to[i] = ReadLine().Split().Select( x => int.Parse( x ) - 1 ).ToArray();
        }
        s.Push( c );
        foreach( int i in Range( 0, n[1] ) ) {
            int e = to[c][i];

            if( e == -2 ) {
                s.Pop();
                c = s.Peek();
            } else {
                c = e;
                s.Push( c );
            }
            WriteLine( c + 1 );
        }
        return;
    }
}
