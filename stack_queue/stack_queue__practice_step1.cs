// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;
using Qu = System.Collections.Generic.Queue<int>;

internal class Program
{
    static void Main()
    {
        int q = int.Parse( ReadLine() );
        Qu q1 = new Qu( q );
        Qu q2 = new Qu( q );

        foreach( int _ in Range( 0, q ) ) {
            int[] t = ReadLine().Split().Select( int.Parse ).ToArray();

            switch( t[0] ) {
            case 1:
                if( t[1] == 1 ) {
                    q1.Enqueue( t[2] );
                } else if( t[1] == 2 ) {
                    q2.Enqueue( t[2] );
                }
                break;
            case 2:
                if( t[1] == 1 ) {
                    WriteLine( q1.Dequeue() );
                } else if( t[1] == 2 ) {
                    WriteLine( q2.Dequeue() );
                }
                break;
            case 3:
                WriteLine( $"{q1.Count} {q2.Count}" );
                break;
            }
        }
        return;
    }
}
