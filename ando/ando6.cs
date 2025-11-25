// 実行時間 20ms
using static System.Console;
using static System.Linq.Enumerable;

class Program
{
    static void Main()
    {
        int n = int.Parse( ReadLine() );

        WriteLine( string.Join( System.Environment.NewLine, Range( 1, n ).Reverse() ) );
        WriteLine( "0!!" );
        return;
    }
}
