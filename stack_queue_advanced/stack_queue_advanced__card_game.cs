// 実行時間 20ms
using System.Collections.Generic;
using static System.Console;
using static System.Linq.Enumerable;

internal class Program
{
    static void Main()
    {
        int[] n = ReadLine().Split().Select( int.Parse ).ToArray();
        var ex = new Stack<bool>();
        var gv = new Stack<bool>();
        var ym = new Queue<bool>( 40 );

        foreach( int i in Range( 0, 40 ) ) {
            ym.Enqueue( i == n[0] - 1 );
        }
        ReadLine();
        foreach( int _ in Range( 0, 5 ) ) {
            if( ym.Dequeue() == true ) {
                WriteLine( 1 );
                return;
            }
        }
        foreach( int i in Range( 2, n[1] - 1 ) ) {
            string[] e = ReadLine().Split();
            int x = int.Parse( e[1] );

            switch( e[0] ) {
            case "draw":
                foreach( int j in Range( 0, x ) ) {
                    if( ym.Dequeue() == true ) {
                        WriteLine( i );
                        return;
                    }
                }
                break;
            case "discard":
                foreach( int j in Range( 0, x ) ) {
                    gv.Push( ym.Dequeue() );
                }
                break;
            case "return_from_the_graveyard":
                foreach( int j in Range( 0, x ) ) {
                    ym.Enqueue( gv.Pop() );
                }
                break;
            case "exclude":
                foreach( int j in Range( 0, x ) ) {
                    ex.Push( ym.Dequeue() );
                }
                break;
            case "return_from_the_exclusion":
                foreach( int j in Range( 0, x ) ) {
                    ym.Enqueue( ex.Pop() );
                }
                break;
            }
        }
        WriteLine( "Lose" );
        return;
    }
}
