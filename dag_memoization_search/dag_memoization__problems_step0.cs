// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );
        var q = new System.Collections.Generic.Queue<int>();

        if( n <= 2 ) {
            WriteLine( 1 );
            return;
        } else if( n == 3 ) {
            WriteLine( 2 );
            return;
        }
        q.Enqueue( 1 );
        q.Enqueue( 1 );
        q.Enqueue( 2 );
        foreach( int _ in Range( 4, n - 3 ) ) {
            q.Dequeue();
            q.Enqueue( q.Sum() % 1000000007 );
        }
        WriteLine( q.Last() );
        return;
    }
}
